using System;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;

namespace Pw.Bootstrapper.Tasks
{
    public class TaskExecutor
    {
        private readonly ProcessRunner _runner;

        public TaskExecutor(ProcessRunner runner)
        {
            _runner = runner;
        }

        public Process Execute(TaskBase task, TextWriter output)
        {
            var runOptions = GetOptions(task);

            if (runOptions == null)
                return null;
            
            runOptions.Output = output;
            return _runner.Execute(runOptions);
        }
        
        public void ExecuteAndWait(TaskBase task)
        {
            Execute(task, Console.Out)?.WaitForExit();
        }

        public string ExecuteAndWaitWithOutput(TaskBase task)
        {
            var runOptions = GetOptions(task);
            
            if (runOptions == null)
                return String.Empty;
            
            var encoding = Conventions.Encodings.Default;
            
            using var memoryStream = new MemoryStream();
            using var writer = new StreamWriter(memoryStream, encoding);
            
            runOptions.Output = writer;
            
            var (process, redirectTask) = _runner.ExecuteWithRedirectTask(runOptions);
            
            process.WaitForExit();
            redirectTask.GetAwaiter().GetResult();
            writer.Dispose();

            return encoding.GetString(memoryStream.GetBuffer());
        }
        
        public RunOptions GetOptions(TaskBase task) => task switch
        {
            RunCommandTask runCommand => GetOptions(runCommand),
            RunExecutableTask runExe => GetOptions(runExe),
            KillProcessTask kill => GetOptions(kill),
            _ => throw new NotImplementedException($"Unknown task type {task}")
        };

        public RunOptions GetOptions(RunCommandTask runCommand)
        {
            return new RunOptions(
                runCommand.Name,
                runCommand.Arguments,
                runCommand.Directory,
                runCommand.EnvironmentArguments);
        }

        public RunOptions GetOptions(RunExecutableTask runExe)
        {
            var fileName = Path.Combine(runExe.Directory, runExe.AppName);
            return new RunOptions(
                fileName,
                runExe.Arguments,
                runExe.Directory,
                runExe.EnvironmentArguments);
        }

        public RunOptions GetOptions(KillProcessTask killProcess)
        {
            var processes = GetProcesses();
            var pattern = new Regex(killProcess.AppNamePattern, RegexOptions.Compiled);

            var pids = processes
                .Where(IsProcessMatch)
                .Select(proc => proc.ProcessId)
                .ToArray();

            if (pids.Length == 0)
                return null;
            
            var command = CreateKillCommand(pids);
            return GetOptions(command);
            
            (int ProcessId, string Line)[] GetProcesses()
            {
                var ps = new RunCommandTask {Name = "ps", Arguments = "ax"};
                var psOutput = ExecuteAndWaitWithOutput(ps);
                
                var processIdRegex = new Regex(@"\s*(\d+)(.+)", RegexOptions.Multiline);
                return processIdRegex
                    .Matches(psOutput)
                    .Select(GetProcessId)
                    .ToArray();

                (int ProcessId, string Line) GetProcessId(Match match)
                {
                    var id = int.Parse(match.Groups[1].Value);
                    var line = match.Groups[2].Value;
                    return (id, line);
                }
            }

            bool IsProcessMatch((int ProcessId, string Line) process) => pattern.IsMatch(process.Line);
            
            RunCommandTask CreateKillCommand(int[] pids) => new RunCommandTask
            {
                Name = "kill",
                Arguments = $"{killProcess.Signal} {string.Join(" ", pids)}",
                EnvironmentArguments = killProcess.EnvironmentArguments
            };
        }
    }
}
