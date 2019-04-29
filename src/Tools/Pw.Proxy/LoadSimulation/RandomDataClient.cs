using System;
using System.Net.Sockets;
using System.Threading;

namespace Pw.Proxy.LoadSimulation
{
    public class RandomDataClient
    {
        private readonly int _number;

        private static Random Random = new Random();

        private const int MaxBufferSize = 102;


        public RandomDataClient(NetworkAddress address, int number)
        {
            _number = number;
            var client = new TcpClient();
            Thread.Sleep(Random.Next(0, 50));
            client.Connect(address.ToIpEndPoint());
            BeginReceiveData(client.Client);
        }

        private void SendRandomPacket(Socket client)
        {
            //Thread.Sleep(Random.Next(20, 100));
            var opCode = Random.Next(1, 10000);
            var length = Random.Next(1, MaxBufferSize);

            var opCodeBytesCount = CompactUIntSerializer.GetBytesCount(opCode);
            var lengthCount = CompactUIntSerializer.GetBytesCount(length);

            var data = new byte[length + opCodeBytesCount + lengthCount];
            Random.NextBytes(data);

            CompactUIntSerializer.GetBytes(opCode).CopyTo(data, 0);
            CompactUIntSerializer.GetBytes(length).CopyTo(data, opCodeBytesCount);

            client.Send(data);

            Log($"Send code {opCode} length {length}");
        }

        private void BeginReceiveData(Socket client)
        {
            var buffer = new byte[1024];
            client.BeginReceive(buffer, 0, 1024, SocketFlags.None, EndReceiveData, null);

            void EndReceiveData(IAsyncResult iar)
            {
                var length = client.EndReceive(iar);
                Log($"Data len {length} received");

                SendRandomPacket(client);

                BeginReceiveData(client);
            }
        }

        private void Log(string message)
        {
            //Console.WriteLine($"Client #{_number}: {message}");
        }
    }
}
