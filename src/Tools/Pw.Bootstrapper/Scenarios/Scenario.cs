using System;
using Pw.Bootstrapper.Tasks;
using Pw.Logging;

namespace Pw.Bootstrapper.Scenarios
{
    public class Scenario
    {
        public string Name { get; }
        private readonly TaskBase[] _tasks;
        private readonly ILogger _logger;
        private readonly TaskExecutor _executor;

        public Scenario(string name, TaskBase[] tasks, ILogger logger, TaskExecutor taskExecutor)
        {
            Name = name;
            _tasks = tasks;
            _logger = logger;
            _executor = taskExecutor;
        }

        public void Run()
        {
            _logger.Info($"Starting {Name}");

            foreach (var task in _tasks)
            {
                _logger.Debug($"Executing {task}..");

                try
                {
                    _executor.ExecuteAndWait(task);
                    _logger.Debug($"Executed {task}");
                }
                catch (Exception ex)
                {
                    _logger.Error($"Error while executing {task}: {ex}");
                }
            }
        }
    }
}
