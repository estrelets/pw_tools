using System;
using System.Collections.Generic;
using System.IO.Pipelines;
using System.Threading;
using System.Threading.Tasks;

namespace Pw.Proxy.Server
{
    public class PacketReceiver
    {
        private readonly IRawDataProducer _rawDataProducer;
        private readonly IPacketReader _packetReader;
        private readonly Pipe _pipe;

        private readonly CancellationTokenSource _readCancellationTokenSource;
        private readonly CancellationTokenSource _writeCancellationTokenSource;

        public PacketReceiver(IRawDataProducer rawDataProducer, IPacketReader packetReader)
        {
            _rawDataProducer = rawDataProducer;
            _packetReader = packetReader;

            _readCancellationTokenSource = new CancellationTokenSource();
            _writeCancellationTokenSource = new CancellationTokenSource();

            _pipe = new Pipe();
            _pipe.Reader.OnWriterCompleted(WriterCompletes, null);
            _pipe.Writer.OnReaderCompleted(ReaderCompletes, null);
        }

        private void WriterCompletes(Exception ex, object _)
        {
            _readCancellationTokenSource.Cancel(ex != null);
        }

        private void ReaderCompletes(Exception ex, object _)
        {
            _writeCancellationTokenSource.Cancel(ex != null);
        }

        public async IAsyncEnumerable<Packet> ReadPackets(CancellationToken cancellationToken)
        {
            
            var combinedToken = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, _readCancellationTokenSource.Token).Token;

            while (!combinedToken.IsCancellationRequested)
            {
                var packet = await _packetReader.Read(_pipe.Reader, combinedToken);

                if(packet == null)
                    break;

                yield return packet;
            }
        }

        public void StartReceive(CancellationToken cancellationToken)
        {
            var combinedToken = CancellationTokenSource.CreateLinkedTokenSource(cancellationToken, _writeCancellationTokenSource.Token).Token;
            Task.Run(() => _rawDataProducer.Produce(_pipe.Writer, combinedToken), combinedToken);
        }
    }
}
