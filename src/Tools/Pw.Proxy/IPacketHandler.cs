using Pw.Proxy.Server;

namespace Pw.Proxy
{
    public interface IPacketHandler
    {
        void Handle(Packet packet, Bridge bridge);
    }
}
