namespace Pw.Bootstrapper.Tasks
{
    public class RunExecutableTask : TaskBase
    {
        public string Directory { get; set; }
        public string AppName { get; set; }
        public string Arguments { get; set; }
        
        public override string ToString() => $"./{AppName} {Arguments}";
    }
}