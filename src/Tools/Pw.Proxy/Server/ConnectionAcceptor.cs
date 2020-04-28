using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Pw.Proxy.Server
{
    public class ConnectionAcceptor
    {
        private readonly Godfather _godfather;
        private readonly TcpListener _listener;

        public ConnectionAcceptor(NetworkAddress listenAddress, NetworkAddress targetAddress, Godfather godfather)
        {
            ListenAddress = listenAddress;
            TargetAddress = targetAddress;
            _godfather = godfather;
            _listener = new TcpListener(listenAddress.ToIpEndPoint());
        }

        public NetworkAddress ListenAddress { get; }
        public NetworkAddress TargetAddress { get; }

        public async Task Start(CancellationToken cancellationToken)
        {
            _listener.Start(1000);
            while (!cancellationToken.IsCancellationRequested)
            {
                var client = await _listener.AcceptSocketAsync();
                await CreateConnection(client);
            }
        }

        private async Task CreateConnection(Socket source)
        {
            var target = await ConnectToTarget();
            _godfather.CreateBridge(source, target);
        }

        private async Task<Socket> ConnectToTarget()
        {
            var endPoint = TargetAddress.ToIpEndPoint();
            var tcpClient = new TcpClient();

            await tcpClient.ConnectAsync(endPoint.Address, endPoint.Port);

            return tcpClient.Client;
        }
    }
}
