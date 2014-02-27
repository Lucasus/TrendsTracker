using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using System;
using TrendsTracker.Tests.E2E.Extensions;

namespace TrendsTracker.Tests.E2E.TestInfrastructure
{
    public class ApplicationRunner : IDisposable
    {
        private IWebDriver driver;
        private const int testPort = 12345;

        public ApplicationRunner()
        {
            driver = new FirefoxDriver();
            driver.Manage().Timeouts().SetScriptTimeout(TimeSpan.FromSeconds(300));
        }

        public void GoTo(string url)
        {
            driver.Navigate().GoToUrl(getAbsoluteUrl(url));
        }

        public void assertContainsText(string text)
        {
            Assert.That(driver.ContainsText(text), Is.True);
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
    }
}
