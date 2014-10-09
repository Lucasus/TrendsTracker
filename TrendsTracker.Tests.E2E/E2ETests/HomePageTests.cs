using TrendsTracker.Tests.E2E.Pages;
using TrendsTracker.Tests.E2E.TestInfrastructure;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendsTracker.Tests.Unit;

namespace TrendsTracker.E2ETests
{
    [TestClass]
    public class HomePageTests : E2ETestBase<HomePage>
    {
        protected override HomePage createPage(ApplicationRunner app) { return new HomePage(app.Driver); }

        [TestMethod, TestCategory(TestCategories.E2E)]
        public void user_enters_HomePage_and_should_see_website_name()
        {
            App.GoTo(page.PageUrl);
            page.AssertHeaderIs("Trends Tracker");
        }
    }
}
