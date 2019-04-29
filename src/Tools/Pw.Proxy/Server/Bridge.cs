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
        private readonly PacketReader _sourceReader;
        private readonly PacketReader _targetReader;

        private CancellationTokenSource _cancellationTokenSource;

        public Bridge(Socket sourceConnection, Socket targetConnection, IPacketHandler packetHandler)
        {
            _packetHandler = packetHandler;

            _sourceConnection = sourceConnection;
            _targetConnection = targetConnection;

            _sourceReader = new PacketReader(sourceConnection);
            _targetReader = new PacketReader(targetConnection);
        }

        public async Task Send(Direction direction, IEnumerable<Packet> packets)
        {
            var socket = direction == Direction.Source
                ? _sourceConnection
                : _targetConnection;

            await Send(socket, packets);
        }

        public void Start()
        {
            _cancellationTokenSource = new CancellationTokenSource();

            Start(_sourceReader, Direction.Source);
            Start(_targetReader, Direction.Target);

            Task Start(PacketReader reader, Direction direction)
                => Task.Run(() => Receive(reader, direction, _cancellationTokenSource.Token));
        }

        public void Stop()
        {
            _cancellationTokenSource.Cancel();
        }

        private async Task Receive(PacketReader reader, Direction direction, CancellationToken cancellationToken)
        {
            reader.BeginReceiveData(cancellationToken);

            await foreach (var packet in reader.Read(cancellationToken))
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