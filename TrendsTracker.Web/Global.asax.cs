using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using System.Web.Security;
using System.Web.SessionState;
using System.Web.Http;
using Castle.Windsor;
using Castle.Windsor.Installer;
using TrendsTracker.Web.Utilities;
using System.Web.Http.Dispatcher;
using TrendsTracker.Web.Infrastructure;
using ProjectTrackerWeb;

namespace TrendsTracker.Web
{
    public class Global : HttpApplication
    {
        private static IWindsorContainer container;

        private static void BootstrapContainer()
        {
            container = new WindsorContainer().Install(FromAssembly.This());
            GlobalConfiguration.Configuration.Services.Replace(
                typeof(IHttpControllerActivator),
                new WinsorControllerActivator(container));
        }

        void Application_Start(object sender, EventArgs e)
        {
            BootstrapContainer();
            AutoMapperConfig.Configure();
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(WebApiConfig.Register);
            RouteConfig.RegisterRoutes(RouteTable.Routes);            
        }

        protected void Application_End()
        {
            container.Dispose();
        }
    }
}