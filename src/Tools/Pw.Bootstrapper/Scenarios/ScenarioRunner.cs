using System;
using System.Linq;
using Pw.Bootstrapper.Configuration;
using Pw.Logging;

namespace Pw.Bootstrapper.Scenarios
{
    public class ScenarioRunner
    {
        private readonly ILogger _logger;
        private readonly Scenario[] _scenarios;
        
        public ScenarioRunner(ConfigurationReader configurationReader, ILogger logger)
        {
            _logger = logger;
            _scenarios = configurationReader.GetScenarios();
        }

        public void Start(string scenarioName)
        {
            var scenario = _scenarios.FirstOrDefault(s => s.Name.Equals(scenarioName, StringComparison.InvariantCultureIgnoreCase));

            if (scenario == null)
            {
                _logger.Error($"Scenario '{scenarioName}' not found");
                return;
            }
            
            scenario.Run();
        }
    }
}
