using Autofac;
using Pw.Bootstrapper.Configuration;
using Pw.Bootstrapper.Scenarios;
using Pw.Bootstrapper.Services;
using Pw.Bootstrapper.Tasks;
using Pw.Configuration;
using Pw.Logging;

namespace Pw.Bootstrapper
{
    public class BootstrapperModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.Register(c => CreateYamlConfigurationReader())
                .As<IConfigurationReader>()
                .SingleInstance();

            builder
                .RegisterType<BootstrapperConfiguration>()
                .SingleInstance();

            builder.RegisterType<ConsoleLogger>().As<ILogger>();

            builder
                .RegisterType<ConfigurationReader>()
                .SingleInstance();

            builder
                .RegisterType<ScenarioRunner>()
                .SingleInstance();
            
            builder
                .RegisterType<FlightEngineer>()
                .SingleInstance();

            builder
                .RegisterType<ProcessRunner>()
                .SingleInstance();

            builder
                .RegisterType<TaskExecutor>()
                .SingleInstance();

            builder
                .RegisterType<ConsoleLogger>()
                .As<ILogger>()
                .SingleInstance();
        }
        
        private YamlConfigurationReader CreateYamlConfigurationReader()
        {
            return YamlConfigurationReader.FromFile("config.yaml", YamlConfigurationCustomization.RegisterTags);
        }
    }
}
