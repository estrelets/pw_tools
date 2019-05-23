using System.Buffers;
using System.Diagnostics;
using System.IO;
using System.Threading.Tasks;

namespace Pw.Bootstrapper.Tasks
{
    public class ProcessRunner
    {
        public Process Execute(RunOptions options)
        {
            var (process, _) = ExecuteWithRedirectTask(options);
            return process;
        }

        public (Process Process, Task RedirectTask) ExecuteWithRedirectTask(RunOptions options)
        {
            var processInfo = new ProcessStartInfo(options.FileName)
            {
                ErrorDialog = false,
                CreateNoWindow = false,
                UseShellExecute = false,
                RedirectStandardOutput = true,
                RedirectStandardError = true,
                WorkingDirectory = options.Directory,
                Arguments = options.Arguments
            };


            if (options.EnvironmentVars != null)
            {
                foreach (var (key, value) in options.EnvironmentVars)
                {
                    processInfo.EnvironmentVariables[key] = value;
                }
            }

            options.Configure?.Invoke(processInfo);

            var process = Process.Start(processInfo);
            var redirectTask = RedirectOutput(process, options.Output);

            return (process, redirectTask);
        }


        private Task RedirectOutput(Process process, TextWriter writer)
        {
            return Task.WhenAll(
                Task.Run(async () => await StartRedirectOutput(process.StandardOutput)),
                Task.Run(async () => await StartRedirectOutput(process.StandardError))
            );

            async Task StartRedirectOutput(StreamReader source)
            {
                while (!source.EndOfStream)
                {
                    using var memoryOwner = MemoryPool<char>.Shared.Rent(256);

                    var length = await source.ReadAsync(memoryOwner.Memory);
                    await writer.WriteAsync(memoryOwner.Memory.Slice(0, length));
                }
            }
        }
    }
}
