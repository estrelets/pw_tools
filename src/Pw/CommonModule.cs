using Autofac.Core;
using Pw.Configuration;

namespace Pw
{
    public class CommonModule : IModule
    {
        public void Configure(IComponentRegistry componentRegistry)
        {
            componentRegistry.AddRegistrationSource(new ConfigurationSectionsRegistrationSource());
        }
    }
}
