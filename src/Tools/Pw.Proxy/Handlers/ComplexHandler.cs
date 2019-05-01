using System.Collections.Generic;
using Pw.Proxy.Server;

namespace Pw.Proxy.Handlers
{
    public class ComplexHandler : IPacketHandler
    {
        private readonly IEnumerable<IPacketHandler> _handlers;

        public ComplexHandler(IEnumerable<IPacketHandler> handlers)
        {
            _handlers = handlers;
        }

        public void Handle(Packet packet, Bridge bridge)
        {
            foreach (var packetHandler in _handlers)
            {
                packetHandler.Handle(packet, bridge);
            }
        }
    }
}
