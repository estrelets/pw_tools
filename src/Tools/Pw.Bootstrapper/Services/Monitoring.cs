using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Pw.Logging;

namespace Pw.Bootstrapper.Services
{
    public class Monitoring
    {
        private static readonly TimeSpan RefreshDelay = TimeSpan.FromSeconds(2);
        
        private readonly ILogger _logger;
        private readonly FlightEngineer _flightEngineer;

        private CancellationTokenSource _watchCts;

        public Monitoring(ILogger logger, FlightEngineer flightEngineer)
        {
            _logger = logger;
            _flightEngineer = flightEngineer;
        }

        public void Start()
        {
            _watchCts = new CancellationTokenSource();
            Task.Run(() => Watch(_watchCts.Token));
        }

        public void Stop()
        {
            _watchCts.Cancel();
        }

        private async Task Watch(CancellationToken cancellationToken)
        {
            while (!cancellationToken.IsCancellationRequested)
            {
                await Task.Delay(RefreshDelay, cancellationToken);
                
                foreach (var service in _flightEngineer.Services)
                {
                    CheckMemoryLeak(service, cancellationToken);
                    CheckCrash(service, cancellationToken);
                }                
            }
        }

        private void CheckCrash(Service service, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
                return;

            if (service.IsWorking)
                return;

            _logger.Error($"Service {service} crashed!");
            _flightEngineer.Start(service);
        }

        private void CheckMemoryLeak(Service service, CancellationToken cancellationToken)
        {
            if (cancellationToken.IsCancellationRequested)
                return;

            if (service.MemoryLimit == default)
                return;

            if (!service.IsWorking)
                return;

            var session = service.Sessions.LastOrDefault();

            if (session == null)
                return;

            var process = session.Process;
            var memoryUsageInMB = process.WorkingSet64 / (1024d * 1024d);

            if (service.MemoryLimit > memoryUsageInMB)
                return;

            _logger.Critical($"Memory leak service : {service}");
            process.Kill();
        }
    }
}
