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
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                StartProxy();
            }
            else
            {
                Parser.Default
                    .ParseArguments<LoadTestOptions, ProxyOptions>(args)
                    .WithParsed<LoadTestOptions>(StartLoadSimulation)
                    .WithParsed<ProxyOptions>(StartProxy)
                    .WithNotParsed(errors => { });
            }
        }

        static void StartProxy()
        {
            var bootstrapper = new Bootstrapper();
            bootstrapper.StartAsProxy();
        }

        static void StartProxy(ProxyOptions proxyOptions)
        {
            if (NetworkAddress.TryParse(proxyOptions.Listen, out var listen)
                && NetworkAddress.TryParse(proxyOptions.Target, out var target))
            {
                var bootstrapper = new Bootstrapper();
                bootstrapper.StartAsProxy(listen, target, proxyOptions.PrintPackets);
            }
            else
            {
                Console.WriteLine($"Parse {nameof(NetworkAddress)} error");
            }
        }
        
        static void StartLoadSimulation(LoadTestOptions options)
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

            NetworkAddress CreateAddress(int port)
                => new NetworkAddress
                {
                    Ip = options.Host,
                    Port = port
                };
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
        
        [Verb("proxy")]
        private class ProxyOptions
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
                    new ProxyOptions
                    {
                        Listen = "127.0.0.1:12315",
                        Target = "127.0.0.1:12314",
                        PrintPackets = true
                    })
                    
            };
        }
    }
}
