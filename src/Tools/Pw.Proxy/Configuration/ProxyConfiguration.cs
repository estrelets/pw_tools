using Pw.Configuration;

namespace Pw.Proxy.Configuration
{
    public class ProxyConfiguration : IConfigurationSection
    {
        public string Name { get; set; }
        public Item[] Proxies { get; set; }
        public bool PrintPackets { get; set; }
        public string PrintPacketFilePath { get; set; }

        public class Item
        {
            public NetworkAddress Listen { get; set; }
            public NetworkAddress Target { get; set; }
        }
    }
}
