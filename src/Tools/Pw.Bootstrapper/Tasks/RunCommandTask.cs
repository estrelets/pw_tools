namespace Pw.Bootstrapper.Tasks
{
    public class RunCommandTask : TaskBase
    {
        public string Name { get; set; }
        public string Arguments { get; set; }
        public string Directory { get; set; }
        
        public override string ToString() => $"{Name} {Arguments}";
    }
}