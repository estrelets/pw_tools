using System;
using System.Diagnostics;
using System.IO;
using Pw.Bootstrapper.Tasks;
using Pw.Logging;

namespace Pw.Bootstrapper.Services
{
    public class Session
    {
        public Process Process { get; private set; }
        private readonly ILogger _logger;
        private readonly TaskExecutor _executor;
        private readonly TextWriter _writer;

        public string Name { get; }
        public TaskBase RunTask { get; }
        public DateTime Started { get; private set; }
        public DateTime? Stopped { get; private set; }
        

        public Session(string name, TaskBase runTask, string logPath, ILogger logger, TaskExecutor executor)
        {
            Name = name;
            RunTask = runTask;

            _logger = logger;
            _executor = executor;
            _writer = CreateWriter(logPath);
        }

        public void Start()
        {
            if (Process != default)
            {
                throw new InvalidOperationException("Already started");
            }

            _logger.Info($"Starting {Name}");
            _logger.Debug($"Executing {RunTask}..");
            Process = _executor.Execute(RunTask, _writer);
            Process.Exited += (sender, args) => Stop();
            _logger.Debug($"Executed {RunTask}");
            
            Started = DateTime.UtcNow;
        }

        public void Stop()
        {
            _logger.Info($"Stopping {Name}");
            _logger.Debug($"Stopping process {RunTask}..");
            Process.Kill(true);
            _writer.Dispose();
            _logger.Debug($"Stop {RunTask} complete");
            
            Stopped = DateTime.UtcNow;
        }

        private static TextWriter CreateWriter(string path)
        {
            var file = File.OpenWrite(path);
            return new StreamWriter(file, Conventions.Encodings.Default);
        }
    }
}
