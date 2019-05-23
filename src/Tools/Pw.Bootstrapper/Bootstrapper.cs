using Autofac;
using Pw.Bootstrapper.Scenarios;
using Pw.Bootstrapper.Services;

namespace Pw.Bootstrapper
{
    public class Bootstrapper
    {
        private readonly IContainer _container;

        public Bootstrapper()
        {
            _container = CreateContainer();
        }

        public void StartServices()
        {
            using var scope = _container.BeginLifetimeScope();
            var orchestrator = scope.Resolve<FlightEngineer>();
            orchestrator.Start();
        }

        public void StopServices()
        {
            using var scope = _container.BeginLifetimeScope();
            var orchestrator = scope.Resolve<FlightEngineer>();
            orchestrator.Stop();
        }

        public void StartScenario(string name)
        {
            using var scope = _container.BeginLifetimeScope();
            var scenarioRunner = scope.Resolve<ScenarioRunner>();
            scenarioRunner.Start(name);
        }

        private IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterModule<CommonModule>();
            containerBuilder.RegisterModule<BootstrapperModule>();

            return containerBuilder.Build();
        }
    }
}
