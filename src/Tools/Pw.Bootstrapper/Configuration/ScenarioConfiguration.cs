using Pw.Bootstrapper.Tasks;

namespace Pw.Bootstrapper.Configuration
{
    public class ScenarioConfiguration
    {
        public string Name { get; set; }
        public TaskBase[] Tasks { get; set; }
    }
}
