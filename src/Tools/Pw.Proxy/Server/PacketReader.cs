using System;
using System.Buffers;
using System.Buffers.Binary;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO.Pipelines;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Pw.Proxy.Server
{
    /// <summary>
    /// Takes socket and produce parsed Packets 
    /// </summary>
    public class PacketReader
    {
        private const int BufferSize = 1024;

        private readonly Socket _socket;
        private readonly Pipe _pipe;

        public PacketReader(Socket socket)
        {
            _socket = socket;
            _pipe = new Pipe();
        }

        public void BeginReceiveData(CancellationToken cancellationToken) => Task.Run(() => Receive(cancellationToken));


        //public void BeginReceiveData()
        //{
        //    //Task.Run(() => Receive());
        //    //var memory = _pipe.Writer.GetMemory(BufferSize);
        //    _socket.BeginReceive(_buffer, 0, _buffer.Length, SocketFlags.None, EndReceiveData, null);

        //    void EndReceiveData(IAsyncResult iar)
        //    {
        //        var length = _socket.EndReceive(iar);

        //        var span = new Span<byte>(_buffer, 0, length);
        //        _pipe.Writer.Write(span);
        //        _pipe.Writer.FlushAsync().GetAwaiter().OnCompleted(BeginReceiveData);
        //    }
        //}


        public async Task Receive(CancellationToken cancellationToken)
        {
            var writer = _pipe.Writer;

            while (!cancellationToken.IsCancellationRequested)
            {
                try
                {
                    var memory = writer.GetMemory(BufferSize);
                    var length = await _socket.ReceiveAsync(memory, SocketFlags.None, cancellationToken);

                    writer.Advance(length);
                    await writer.FlushAsync(cancellationToken);
                }
                catch (Exception ex)
                {
                    writer.Complete(ex);
                    throw;
                }
            }
        }

        public async IAsyncEnumerable<Packet> Read(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                yield return await ReadPacket(_pipe.Reader, cancellationToken);
            }
        }

        private async Task<Packet> ReadPacket(PipeReader reader, CancellationToken cancellationToken)
        {
            var sw = Stopwatch.StartNew();
            var packet = new Packet();

            packet.OpCode = await ReadCuint(reader, cancellationToken);
            packet.Data = await ReadPayload(reader, cancellationToken);

            sw.Stop();
            packet.Elapsed = sw.ElapsedMilliseconds;
            return packet;
        }

        private async Task<byte[]> ReadPayload(PipeReader reader, CancellationToken cancellationToken)
        {
            var length = await ReadCuint(reader, cancellationToken);
            var memory = new byte[length];

            var alreadyCopied = 0;

            while (!cancellationToken.IsCancellationRequested)
            {
                var readResult = await reader.ReadAsync(cancellationToken);
                var buffer = readResult.Buffer;

                var copied = Copy(memory, buffer, alreadyCopied);
                reader.AdvanceTo(buffer.GetPosition(copied));

                alreadyCopied += copied;

                if (alreadyCopied == length)
                    break;
            }

            return memory;
        }

        private int Copy(Memory<byte> memory, ReadOnlySequence<byte> buffer, int alreadyRed)
        {
            var bytesToRead = (int)Math.Min(buffer.Length, memory.Length - alreadyRed);

            var memorySlice = memory.Span.Slice(alreadyRed, bytesToRead);
            var bufferSlice = memorySlice.Slice(0, bytesToRead);

            bufferSlice.CopyTo(memorySlice);
            return bytesToRead;
        }


        async Task<int> ReadCuint(PipeReader reader, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                var readResult = await reader.ReadAsync(cancellationToken);
                var buffer = readResult.Buffer;

                if (buffer.IsEmpty)
                {
                    reader.AdvanceTo(buffer.Start);
                    continue;
                }

                var optionalValue = TryReadCUint(buffer, reader);

                if (optionalValue == null)
                {
                    reader.AdvanceTo(buffer.Start);
                    continue;
                }

                return optionalValue.Value;
            }

            return 0;
        }

        private int? TryReadCUint(ReadOnlySequence<byte> buffer, PipeReader reader)
        {
            var firstByte = buffer.Slice(0, 1).ToArray()[0];
            var needBytes = CompactUIntSerializer.GetBytesCountByHeader(firstByte);

            if (buffer.Length < needBytes)
            {
                return null;
            }

            if (needBytes == 1)
            {
                reader.AdvanceTo(buffer.GetPosition(needBytes));
                return firstByte;
            }

            var span = buffer.Slice(0, needBytes).ToArray();
            reader.AdvanceTo(buffer.GetPosition(needBytes));

            return CompactUIntSerializer.GetNumber(span);
        }
    }
}