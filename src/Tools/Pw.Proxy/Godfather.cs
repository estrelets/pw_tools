using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Sockets;
using System.Threading;
using System.Threading.Tasks;
using Pw.Logging;
using Pw.Proxy.Configuration;
using Pw.Proxy.Handlers;
using Pw.Proxy.Server;

namespace Pw.Proxy
{
    public class Godfather
    {
        private readonly ProxyConfiguration _configuration;
        private readonly PerformanceAnalyzer _performanceAnalyzer;
        private readonly ILogger _logger;
        private readonly List<Bridge> _bridges;
        private readonly List<ConnectionAcceptor> _receivers;

        public IReadOnlyCollection<Bridge> Bridges => _bridges;
        public IReadOnlyCollection<ConnectionAcceptor> Receivers => _receivers;

        public Godfather(ProxyConfiguration configuration, PerformanceAnalyzer performanceAnalyzer, ILogger logger)
        {
            _configuration = configuration;
            _performanceAnalyzer = performanceAnalyzer;

            _logger = logger;

            _bridges = new List<Bridge>();
            _receivers = new List<ConnectionAcceptor>();
        }

        public Task StartAll(CancellationToken cancellationToken = default)
        {
            var tasks = _configuration
                .Proxies
                .Select(proxyConfig => StartReceive(proxyConfig.Listen, proxyConfig.Target, cancellationToken));

            return Task.WhenAll(tasks);
        }

        public async Task StartReceive(NetworkAddress listenAddress, NetworkAddress targetAddress, CancellationToken cancellationToken = default)
        {
            var receiver = new ConnectionAcceptor(listenAddress, targetAddress, this);
            _receivers.Add(receiver);

            _logger.Info($"Start swapping from={listenAddress} to={targetAddress}");

            await receiver.Start(cancellationToken);

            _logger.Info($"Swapping from={listenAddress} to={targetAddress} stopped");
        }

        public void CreateBridge(Socket source, Socket target)
        {
            var handler = CreateHandler();
            var bridge = new Bridge(source, target, handler, _performanceAnalyzer);
            _logger.Info($"New bridge={bridge}");
            _bridges.Add(bridge);
            bridge.Start();
        }

        private IPacketHandler CreateHandler()
        {
            var handlers = new List<IPacketHandler>();
            
            handlers.Add(new EchoHandler());

            if (_configuration.PrintPackets)
            {
                handlers.Add(new PacketsPrintHandler());
            }

            AddPerformanceAnalyzeHandlers(handlers);

            return new ComplexHandler(handlers);
        }

        [Conditional(ConditionalOptions.CollectStatistic)]
        private void AddPerformanceAnalyzeHandlers(List<IPacketHandler> handlers)
        {
            if(_performanceAnalyzer == null)
                return;

            handlers.Insert(0, new StartHandlerMeasure(_performanceAnalyzer));
            handlers.Add(new FinishHandlerMeasure(_performanceAnalyzer));
        }

    }
}
