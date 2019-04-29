using System;
using System.Collections.Generic;
using System.Linq;
using Autofac;
using Autofac.Core;
using Autofac.Core.Activators.Delegate;
using Autofac.Core.Lifetime;
using Autofac.Core.Registration;

namespace Pw.Configuration
{
    public class ConfigurationSectionsRegistrationSource : IRegistrationSource
    {
        public bool IsAdapterForIndividualComponents => false;

        public IEnumerable<IComponentRegistration> RegistrationsFor(Service service, Func<Service, IEnumerable<IComponentRegistration>> registrationAccessor)
        {
            var serviceWithType = service as IServiceWithType;
            if (serviceWithType == null)
                return Empty();

            var isConfigSectionType = typeof(IConfigurationSection).IsAssignableFrom(serviceWithType.ServiceType);
            if (!isConfigSectionType)
            {
                return Empty();
            }


            var registration = new ComponentRegistration(
                Guid.NewGuid(),
                new DelegateActivator(serviceWithType.ServiceType, (ctx, parameters) =>
                {
                    var sectionType = serviceWithType.ServiceType;
                    var configReader = ctx.Resolve<IConfigurationReader>();

                    var method = configReader
                        .GetType()
                        .GetMethod(nameof(IConfigurationReader.Read))
                        .MakeGenericMethod(sectionType);

                    return method.Invoke(configReader, new[] { sectionType.Name });
                }),
                new CurrentScopeLifetime(),
                InstanceSharing.None,
                InstanceOwnership.OwnedByLifetimeScope,
                new[] { service },
                new Dictionary<string, object>());

            return new IComponentRegistration[] { registration };

            IEnumerable<IComponentRegistration> Empty() => Enumerable.Empty<IComponentRegistration>();
        }
    }
}
