using Pw.Proxy.Server;

namespace Pw.Proxy.Handlers
{
    public class EchoHandler : IPacketHandler
    {
        public void Handle(Packet packet, Bridge bridge)
        {
            var dir = packet.Direction.Revert();
            bridge.Send(dir, new[] {packet}).GetAwaiter().GetResult();
        }
    }
}
