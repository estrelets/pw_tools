using Pw.Bootstrapper.Tasks;

namespace Pw.Bootstrapper.Configuration
{
    public class ServiceConfiguration
    {
        public string Name { get; set; }
        public string LogFile { get; set; }
        public TaskBase RunTask { get; set; }
        public double MemoryLimit { get; set; }
    }
}
