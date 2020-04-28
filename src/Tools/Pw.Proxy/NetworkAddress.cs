using System;
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

        public static bool TryParse(string src, out NetworkAddress result)
        {
            result = null;

            if (!src.Contains(':'))
                return false;

            var words = src.Split(':', StringSplitOptions.RemoveEmptyEntries);

            if (words.Length != 2)
                return false;

            if (IPAddress.TryParse(words[0], out var ip) && Int32.TryParse(words[1], out var port))
            {
                result = new NetworkAddress {Ip = ip.ToString(), Port = port};
                return true;
            }

            return false;
        }
    }
}
