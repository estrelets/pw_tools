using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pw.Bootstrapper.Scenarios;
using Pw.Bootstrapper.Tasks;
using Pw.Logging;

namespace Pw.Bootstrapper.Configuration
{
    public class ConfigurationReader
    {
        private readonly BootstrapperConfiguration _configuration;
        private readonly ILogger _logger;
        private readonly TaskExecutor _taskExecutor;

        public ConfigurationReader(BootstrapperConfiguration configuration, ILogger logger, TaskExecutor taskExecutor)
        {
            _configuration = configuration;
            _logger = logger;
            _taskExecutor = taskExecutor;
        }

        public Service[] GetServices()
        {
            return _configuration.Services
                .Select(CreateService)
                .ToArray();
        }

        public Scenario[] GetScenarios()
        {
            return _configuration.Scenarios
                .Select(CreateScenario)
                .ToArray();
        }
        
        private Service CreateService(ServiceConfiguration config)
        {
            FixDirectory(config.RunTask);
            FixEnvironmentVariables(config.RunTask);
            
            var logFilePath = GenerateLogPath(config);
            return new Service(config.Name, config.RunTask, logFilePath, _logger, _taskExecutor)
            {
                MemoryLimit = config.MemoryLimit
            };
        }

        private Scenario CreateScenario(ScenarioConfiguration config)
        {
            foreach (var task in config.Tasks)
            {
                FixDirectory(task);
                FixEnvironmentVariables(task);
            }

            return new Scenario(config.Name, config.Tasks, _logger, _taskExecutor);
        }
        
        private void FixEnvironmentVariables(TaskBase task)
        {
            if (task is RunExecutableTask runExe)
            {
                var variables = MergeVariables(_configuration.BaseEnvironmentArguments, runExe.EnvironmentArguments);
                runExe.EnvironmentArguments = variables;
            }
        }

        private void FixDirectory(TaskBase task)
        {
            if (task is RunExecutableTask runExe)
            {
                runExe.Directory = FixWorkingDirectory(runExe.Directory);
            }

            if (task is RunCommandTask runCommand)
            {
                runCommand.Directory = FixWorkingDirectory(runCommand.Directory);
            }
        }

        private string FixWorkingDirectory(string dir)
        {
            if (Path.IsPathRooted(dir))
            {
                return dir;
            }

            return dir == null 
                ? _configuration.BaseDirectory 
                : Path.Combine(_configuration.BaseDirectory, dir);
        }

        private string GenerateLogPath(ServiceConfiguration config)
        {
            if (config.LogFile != null && Path.IsPathRooted(config.LogFile))
            {
                return config.LogFile;
            }
            
            var fileName = config.LogFile ?? Path.ChangeExtension(config.Name, "log");
            return Path.Combine(_configuration.LogsDirectory, fileName);
        }

        private Dictionary<string, string> MergeVariables(
            Dictionary<string, string> baseVariables,
            Dictionary<string, string> variables)
        {
            variables ??= new Dictionary<string, string>();

            foreach (var (key, value) in baseVariables)
            {
                if (variables.ContainsKey(key))
                    continue;

                variables[key] = value;
            }

            return variables;
        }
    }
}
