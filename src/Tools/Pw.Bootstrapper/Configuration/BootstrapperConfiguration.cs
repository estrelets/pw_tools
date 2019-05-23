using System.Collections.Generic;
using Pw.Configuration;

namespace Pw.Bootstrapper.Configuration
{
    public class BootstrapperConfiguration : IConfigurationSection
    {
        public string BaseDirectory { get; set; }
        public string LogsDirectory { get; set; }
        public Dictionary<string, string> BaseEnvironmentArguments { get; set; }
        
        public ServiceConfiguration[] Services { get; set; }
        public ScenarioConfiguration[] Scenarios { get; set; }
    }
}
