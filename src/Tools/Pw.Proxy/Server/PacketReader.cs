using System;
using System.Buffers;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Pw.Proxy.Server
{
    public class PacketReader : IPacketReader
    {
        public async Task<Packet> Read(PipeReader reader, CancellationToken cancellationToken)
        {
            var packet = new Packet();

            packet.OpCode = await ReadCuint(reader, cancellationToken);
            packet.Data = await ReadPayload(reader, cancellationToken);

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
            var bytesToRead = (int) Math.Min(buffer.Length, memory.Length - alreadyRed);

            var memorySlice = memory.Span.Slice(alreadyRed, bytesToRead);
            var bufferSlice = buffer.Slice(0, bytesToRead);

            bufferSlice.CopyTo(memorySlice);
            return bytesToRead;
        }

        private async Task<int> ReadCuint(PipeReader reader, CancellationToken cancellationToken)
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

            if (buffer.Length < needBytes) return null;

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
