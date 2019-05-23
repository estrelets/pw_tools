using System;
using System.Linq;
using System.Threading;

namespace Pw.Bootstrapper
{
    class Program
    {
        private const string StartServicesArg = "services";
        
        private static readonly Bootstrapper Bootstrapper = new Bootstrapper();
        private static readonly AutoResetEvent ExitEvent = new AutoResetEvent(false);
        
        static void Main(string[] args)
        {
            if (args == null || args.Length == 0)
            {
                PrintUsage();
                return;
            }

            var arg = args.First();

            if (arg.Equals(StartServicesArg, StringComparison.InvariantCultureIgnoreCase))
            {
                StartServices();
            }
            else
            {
                StartScenario(arg);
            }
        }

        private static void PrintUsage()
        {
            Console.WriteLine($"To start services: dotnet booter.dll {StartServicesArg}");
            Console.WriteLine($"To start scenario: dotnet booter.dll scenario_name");
        }
        
        private static void StartScenario(string scenarioName)
        {
            Bootstrapper.StartScenario(scenarioName);
        }


        private static void StartServices()
        {
            AppDomain.CurrentDomain.ProcessExit += OnExit;
            Console.CancelKeyPress += OnExit;
            
            Start();

            Console.WriteLine("Press any key to stop");
            Console.ReadKey();
            Stop();
        }
        
        private static void OnExit(object sender, EventArgs e)
        {
            Stop();
            ExitEvent.Set();
        }

        private static void Start() => Bootstrapper.StartServices();
        private static void Stop() => Bootstrapper.StopServices();
    }
}