using System;
using System.Collections.Concurrent;
using System.IO;
using System.Text;
using System.Threading;
using Pw.Proxy.Server;

namespace Pw.Proxy.Handlers
{
    public class PacketsPrintHandler: IPacketHandler, IDisposable
    {
        private readonly Timer _savePackets;
        private readonly string _outputFilePath;
        private readonly ConcurrentQueue<Packet> _packetsQueue;

        public PacketsPrintHandler(string path)
        {
            _outputFilePath = path;
            _packetsQueue = new ConcurrentQueue<Packet>();
            _savePackets = new Timer(_ => SavePackets(), null, TimeSpan.Zero, TimeSpan.FromSeconds(5));
        }
        
        public void Handle(Packet packet, Bridge bridge)
        {
            _packetsQueue.Enqueue(packet);
        }

        private void SavePackets()
        {
            var output = new StringBuilder();

            while (_packetsQueue.TryDequeue(out var packet))
            {
                Write(packet);
            }
            
            if(output.Length == 0)
                return;
            
            File.AppendAllText(_outputFilePath, output.ToString(), Conventions.Encodings.Default);

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
