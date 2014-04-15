using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.PhantomJS;
using System;
using System.Configuration;

namespace TrendsTracker.Tests.E2E.TestInfrastructure
{
    public class ApplicationRunner : IDisposable
    {
        private IWebDriver driver;
        private int testPort;

        public IWebDriver Driver { get { return driver; } }

        public ApplicationRunner()
        {
            testPort = Int32.Parse(ConfigurationManager.AppSettings.Get("Port"));
            //driver = new FirefoxDriver();
            driver = new PhantomJSDriver();
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(3000));
        }

        public void GoTo(string url)
        {
            driver.Navigate().GoToUrl(getAbsoluteUrl(url));  
        }

        public void Dispose()
        {
            driver.Quit();
        }

        private string getAbsoluteUrl(string relativeUrl)
        {
            if (!relativeUrl.StartsWith("/"))
            {
                relativeUrl = "/" + relativeUrl;
            }
            return String.Format("http://localhost:{0}{1}", testPort, relativeUrl);
        }

        public void FixEfProviderServicesProblem()
        {
            //Fixes problem in TeamCity builds:

            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
