using Pw.Bootstrapper.Configuration;
using Pw.Logging;

namespace Pw.Bootstrapper.Services
{
    public class FlightEngineer
    {
        private readonly ILogger _logger;
        private readonly Monitoring _monitor;
        
        public Service[] Services { get; }
        
        public FlightEngineer(ILogger logger, ConfigurationReader configReader)
        {
            _logger = logger;
            Services = configReader.GetServices();
            _monitor = new Monitoring(_logger, this);
        }
        
        
        public void Start()
        {
            foreach (var service in Services)
            {
                Start(service);
            }
            
            StartWatch();
        }
        
        public void Stop()
        {
            StopWatch();
            
            foreach (var service in Services)
            {
                service.Stop();
            }
        }

        public void Start(Service service)
        {
            _logger.Info($"Starting {service}");
            service.Start();
            _logger.Info($"Started {service}");
        }
        
        public void Stop(Service service)
        {
            _logger.Info($"Stopping {service}");
            service.Stop();
            _logger.Info($"Stopped {service}");
        }

        private void StartWatch() => _monitor.Start();
        private void StopWatch() => _monitor.Stop();
    }
}
