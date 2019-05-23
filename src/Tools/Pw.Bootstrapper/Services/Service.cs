using System.Collections.Generic;
using System.Linq;
using Pw.Bootstrapper.Services;
using Pw.Bootstrapper.Tasks;
using Pw.Logging;

namespace Pw.Bootstrapper
{
    public class Service
    {
        private readonly string _logFilePath;
        private readonly ILogger _logger;
        private readonly TaskExecutor _taskExecutor;
        private readonly List<Session> _sessions;
        
        public string Name { get; set; }
        public TaskBase RunTask { get; set; }
        public double MemoryLimit { get; set; }
        
        public IReadOnlyList<Session> Sessions => _sessions;
        public bool IsWorking => Sessions.LastOrDefault()?.Stopped != null;
        
        public Service(string name, TaskBase runTask, string logFilePath, ILogger logger, TaskExecutor taskExecutor)
        {
            Name = name;
            RunTask = runTask;
            _logFilePath = logFilePath;
            _logger = logger;
            _taskExecutor = taskExecutor;
            _sessions = new List<Session>();
        }

        public void Start()
        {
            if(IsWorking)
                return;
            
            var session = new Session(Name, RunTask, _logFilePath, _logger, _taskExecutor);
            _sessions.Add(session);
            session.Start();
        }

        public void Stop()
        {
            _sessions.LastOrDefault()?.Stop();
        }

        public override string ToString() => Name;
    }
}
