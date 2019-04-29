using System;
using System.Collections.Generic;
using System.Linq;
using CommandLine;
using CommandLine.Text;
using Pw.Proxy.LoadSimulation;

namespace Pw.Proxy
{
    class Program
    {
        static int Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                var bootstrapper = new Bootstrapper();
                bootstrapper.StartAsProxy();
                return 0;
            }

            return Parser.Default
                .ParseArguments<LoadTestOptions>(args)
                .MapResult(StartLoadSimulation, errors => -1);
        }

        [Verb("simulation")]
        private class LoadTestOptions
        {
            [Option("noserver", HelpText = "Prevent start listener", Default = false)]
            public bool NoServer { get; set; }

            [Option("count", HelpText = "Clients count", Required = true)]
            public int ClientCount { get; set; }

            [Option("listen", HelpText = "Port to listen", Default = 12314)]
            public int ProxyPort { get; set; }

            [Option("proxy", HelpText = "Proxy port", Default = 12315)]
            public int ListenPort { get; set; }

            [Option("host", Default = "127.0.0.1")]
            public string Host { get; set; }

            [Usage(ApplicationAlias = "proxy.exe")]
            public static IEnumerable<Example> Usage => new[]
            {
                new Example("Start load simulation with 1 client",
                    new LoadTestOptions
                    {
                        ClientCount = 1,
                        ListenPort = 12314,
                        ProxyPort = 12315,
                        NoServer = false,
                        Host = "127.0.0.1"
                    }),

                new Example("Start 100 clients without server",
                    new LoadTestOptions
                    {
                        ClientCount = 100,
                        ListenPort = 12314,
                        ProxyPort = 12315,
                        NoServer = true,
                        Host = "127.0.0.1"
                    }),
            };
        }

        static int StartLoadSimulation(LoadTestOptions options)
        {
            EchoServer server = null;
            if (!options.NoServer)
            {
                server = new EchoServer(CreateAddress(options.ListenPort));
            }

            var proxyAddress = CreateAddress(options.ProxyPort);

            var clients = Enumerable.Range(0, options.ClientCount)
                .Select(i => new RandomDataClient(proxyAddress, i))
                .ToArray();

            Console.ReadLine();
            GC.KeepAlive(server);
            GC.KeepAlive(clients);

            return 0;

            NetworkAddress CreateAddress(int port)
                => new NetworkAddress
                {
                    Ip = options.Host,
                    Port = port
                };
        }
    }
}
