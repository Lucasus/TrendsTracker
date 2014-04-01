using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using TrendsTracker.Infrastructure;
using TrendsTracker.Web.Infrastructure.Facilities;

namespace TrendsTracker.Web.Infrastructure
{
    public class PersistenceInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.AddFacility<EntityFrameworkFacility>();

            container.Register(Classes.FromAssemblyContaining(typeof(Repository<>))
                                .BasedOn(typeof(Repository<>))
                                .LifestyleTransient());
        }
    }
}