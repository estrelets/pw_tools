using System.Collections.Generic;

namespace Pw.Bootstrapper.Tasks
{
    public abstract class TaskBase
    {
        public virtual Dictionary<string, string> EnvironmentArguments { get; set; }
    }
}
