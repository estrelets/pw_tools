using System;
using System.Collections.Concurrent;
using System.Text;
using System.Threading;
using Pw.Proxy.Server;

namespace Pw.Proxy.Handlers
{
    public class PacketsPrintHandler: IPacketHandler, IDisposable
    {
        private readonly Timer _savePackets;
        private readonly ConcurrentQueue<Packet> _packetsQueue;

        public PacketsPrintHandler()
        {
            _packetsQueue = new ConcurrentQueue<Packet>();
            _savePackets = new Timer(_ => PrintPackets(), null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
        }
        
        public void Handle(Packet packet, Bridge bridge)
        {
            _packetsQueue.Enqueue(packet);
        }

        private void PrintPackets()
        {
            var output = new StringBuilder();

            while (_packetsQueue.TryDequeue(out var packet))
            {
                Write(packet);
            }
            
            if(output.Length == 0)
                return;
            
            Console.WriteLine(output);

            void Write(Packet p)
            {
                output.AppendLine($"{p.OpCode} {p.Direction}:");
                output.AppendLine(BitConverter.ToString(p.Data).Replace('-', ' '));
            }
        }

        public void Dispose()
        {
            _savePackets?.Dispose();
        }
    }
}
