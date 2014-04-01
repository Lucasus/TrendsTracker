using Castle.MicroKernel.Facilities;
using Castle.MicroKernel.Registration;
using TrendsTracker.Infrastructure;
using TrendsTracker.Persistence;

namespace TrendsTracker.Web.Infrastructure.Facilities
{
    public class EntityFrameworkFacility : AbstractFacility
    {
        protected override void Init()
        {
            Kernel.Register(Component.For<PersistenceContext>().LifestylePerWebRequest());
        }
    }
}