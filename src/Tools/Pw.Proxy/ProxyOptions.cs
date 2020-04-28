using System.Collections.Generic;
using CommandLine;
using CommandLine.Text;

namespace Pw.Proxy
{
    [Verb("proxy")]
    public class ProxyOptions
    {
        [Option("listen", HelpText = "Network address to list (ip:port)", Required = true)]
        public string Listen { get; set; }

        [Option("target", HelpText = "Network address to connect (ip:port)", Required = true)]
        public string Target { get; set; }

        [Option("print", HelpText = "Print packets to std", Required = false, Default = false)]
        public bool PrintPackets { get; set; }

        [Usage(ApplicationAlias = "proxy.exe")]
        public static IEnumerable<Example> Usage => new[]
        {
            new Example("Start load simulation with 1 client",
                new ProxyOptions {Listen = "127.0.0.1:12315", Target = "127.0.0.1:12314", PrintPackets = true})
        };
    }
}
