using Autofac;
using Pw.Configuration;
using Pw.Logging;
using Pw.Proxy.Configuration;
using Pw.Proxy.Server;

namespace Pw.Proxy
{
    public class Bootstrapper
    {
        private readonly IContainer _container;

        public Bootstrapper()
        {
            _container = CreateContainer();
        }

        public void StartAsProxy()
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                var gf = scope.Resolve<Godfather>();
                gf.StartAll().GetAwaiter().GetResult();
            }
        }

        public void StartAsProxy(NetworkAddress listen, NetworkAddress target)
        {
            using (var scope = _container.BeginLifetimeScope())
            {
                var config = scope.Resolve<ProxyConfiguration>();
                config.Proxies = new[]
                {
                    new ProxyConfiguration.Item
                    {
                        Listen = listen, Target = target
                    }
                };

                var gf = scope.Resolve<Godfather>();
                gf.StartAll().GetAwaiter().GetResult();
            }
        }

        private IContainer CreateContainer()
        {
            var containerBuilder = new ContainerBuilder();

            containerBuilder.RegisterModule<CommonModule>();
            RegisterDependencies(containerBuilder);

            return containerBuilder.Build();
        }

        private void RegisterDependencies(ContainerBuilder builder)
        {
            builder.Register(c => CreateYamlConfigurationReader())
                .As<IConfigurationReader>()
                .SingleInstance();

            builder
                .RegisterType<ProxyConfiguration>()
                .SingleInstance();

            builder.RegisterType<PerformanceAnalyzer>().SingleInstance();
            builder.RegisterType<ConsoleLogger>().As<ILogger>();
            builder.RegisterType<Godfather>();
        }

        private YamlConfigurationReader CreateYamlConfigurationReader()
        {
            return YamlConfigurationReader.FromFile("config.yaml");
        }
    }
}
