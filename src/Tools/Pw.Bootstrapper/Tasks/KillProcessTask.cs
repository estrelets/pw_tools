namespace Pw.Bootstrapper.Tasks
{
    public class KillProcessTask : TaskBase
    {
        public string AppNamePattern { get; set; }
        public int Signal { get; set; }

        public override string ToString() => $"kill {Signal} {AppNamePattern}";
    }
}