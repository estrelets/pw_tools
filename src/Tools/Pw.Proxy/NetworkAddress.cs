using System.Net;

namespace Pw.Proxy
{
    public class NetworkAddress
    {
        public string Ip { get; set; }
        public int Port { get; set; }

        public IPEndPoint ToIpEndPoint()
        {
            return new IPEndPoint(IPAddress.Parse(Ip), Port);
        }

        public override string ToString()
        {
            return $"{Ip}:{Port}";
        }
    }
}