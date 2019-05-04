using Pw.Proxy.Server;

namespace Pw.Proxy.Handlers
{
    public class StartHandlerMeasure : IPacketHandler
    {
        private readonly PerformanceAnalyzer _performanceAnalyzer;

        public StartHandlerMeasure(PerformanceAnalyzer performanceAnalyzer)
        {
            _performanceAnalyzer = performanceAnalyzer;
        }

        public void Handle(Packet packet, Bridge bridge)
        {
            _performanceAnalyzer.StartHandle(packet);
        }
    }

    public class FinishHandlerMeasure : IPacketHandler
    {
        private readonly PerformanceAnalyzer _performanceAnalyzer;

        public FinishHandlerMeasure(PerformanceAnalyzer performanceAnalyzer)
        {
            _performanceAnalyzer = performanceAnalyzer;
        }

        public void Handle(Packet packet, Bridge bridge)
        {
            _performanceAnalyzer.FinishHandle(packet);
        }
    }
}
