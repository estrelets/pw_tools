using System;
using System.Net.Sockets;

namespace Pw.Proxy.LoadSimulation
{
    public class EchoServer
    {
        private TcpListener server;

        public EchoServer(NetworkAddress listAddress)
        {
            server = new TcpListener(listAddress.ToIpEndPoint());
            server.Start(1000);
            BeginReceiveClient();
        }

        private void BeginReceiveClient()
        {
            server.BeginAcceptSocket(EndReceiveClient, null);

            void EndReceiveClient(IAsyncResult iar)
            {
                var client = server.EndAcceptSocket(iar);
                SendHandshake(client);

                BeginReceiveData(client);

                BeginReceiveClient();
            }
        }

        private void SendHandshake(Socket client)
        {
            var buffer = new byte[]
            {
                0x01,
                0x02,
                0x01,
                0x02,
            };

            client.BeginSend(buffer, 0, 4, SocketFlags.None, null, null);
        }

        private void BeginReceiveData(Socket client)
        {
            var buffer = new byte[1024];
            client.BeginReceive(buffer, 0, 1024, SocketFlags.None, EndReceiveData, null);

            void EndReceiveData(IAsyncResult iar)
            {
                var length = client.EndReceive(iar);

                client.BeginSend(buffer, 0, length, SocketFlags.None, null, null);

                BeginReceiveData(client);
            }
        }
    }
}
