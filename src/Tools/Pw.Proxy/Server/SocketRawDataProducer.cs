using System;
using System.IO.Pipelines;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Pw.Proxy.Server
{
    public class SocketRawDataProducer : IRawDataProducer
    {
        private const int BufferSize = 1024;
        private readonly Socket _socket;

        public SocketRawDataProducer(Socket socket)
        {
            _socket = socket;
        }

        public async Task Produce(PipeWriter writer, CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
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
}
