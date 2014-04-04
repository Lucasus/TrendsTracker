using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using TrendsTracker.Infrastructure;

namespace TrendsTracker.Web.Infrastructure.Installers
{
    public class ComponentsInstaller : IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Component.For<UnitOfWork>()
                                .LifestyleTransient());

            container.Register(Classes.FromThisAssembly()
                                .BasedOn<ApiController>()
                                .LifestyleTransient());
        }
    }
}