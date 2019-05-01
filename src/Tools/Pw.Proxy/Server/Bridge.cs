using System;
using System.Collections.Generic;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;

namespace Pw.Proxy.Server
{
    public class Bridge
    {
        private readonly Socket _sourceConnection;
        private readonly Socket _targetConnection;
        private readonly IPacketHandler _packetHandler;
        private readonly PacketReceiver _sourceReceiver;
        private readonly PacketReceiver _targetReceiver;

        private CancellationTokenSource _cancellationTokenSource;

        public Bridge(Socket sourceConnection, Socket targetConnection, IPacketHandler packetHandler, PerformanceAnalyzer performanceAnalyzer)
        {
            _packetHandler = packetHandler;

            _sourceConnection = sourceConnection;
            _targetConnection = targetConnection;

            _sourceReceiver = CreateReceiver(sourceConnection);
            _targetReceiver = CreateReceiver(targetConnection);

            PacketReceiver CreateReceiver(Socket s) =>
                new PacketReceiver(new SocketRawDataProducer(s), new PacketReader(performanceAnalyzer));
        }

        public Task Send(Direction direction, IEnumerable<Packet> packets)
        {
            var socket = direction == Direction.Source
                ? _sourceConnection
                : _targetConnection;

            return Send(socket, packets);
        }

        public void Start()
        {
            _cancellationTokenSource = new CancellationTokenSource();

            Start(_sourceReceiver, Direction.Source);
            Start(_targetReceiver, Direction.Target);

            Task Start(PacketReceiver reader, Direction direction)
                => Task.Run(() => Receive(reader, direction, _cancellationTokenSource.Token));
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
        }

        private async Task Receive(PacketReceiver reader, Direction direction, CancellationToken cancellationToken)
        {
            reader.StartReceive(cancellationToken);

            await foreach (var packet in reader.ReadPackets(cancellationToken))
            {
                packet.Direction = direction;
                _packetHandler.Handle(packet, this);
            }
        }

        private async Task Send(Socket destination, IEnumerable<Packet> packets)
        {
            var segments = new List<ArraySegment<byte>>();

            foreach (var packet in packets)
            {
                var opCodeBuffer = CompactUIntSerializer.GetBytes(packet.OpCode);
                var lengthBuffer = CompactUIntSerializer.GetBytes(packet.Data.Length);

                segments.Add(opCodeBuffer);
                segments.Add(lengthBuffer);
                segments.Add(packet.Data);
            }

            await destination.SendAsync(segments, SocketFlags.None);
        }
    }
}
