using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.Tests.E2E.Pages
{
    public class HomePage : Page
    {
        public HomePage(IWebDriver driver) : base(driver) { }
        public override string PageUrl { get { return ""; } }

        public void AssertHeaderIs(string header)
        {
            Assert.IsTrue(Tag("body").ContainsText(header));
        }
    }
}
