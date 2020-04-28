using System;
using CommandLine;

// ReSharper disable UnusedMember.Local

namespace Pw.Proxy
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //test
            if (args == null || args.Length == 0)
            {
                StartProxy();
            }
            else
            {
                Parser.Default.ParseArguments<ProxyOptions>(args)
                    .WithParsed(StartProxy)
                    .WithNotParsed(errors =>
                    {
                        foreach (var error in errors)
                        {
                            Console.WriteLine(error);
                        }
                    });
            }
        }

        private static void StartProxy()
        {
            var bootstrapper = new Bootstrapper();
            bootstrapper.StartAsProxy();
        }

        private static void StartProxy(ProxyOptions proxyOptions)
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


    }
}
