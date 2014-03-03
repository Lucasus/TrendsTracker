using TrendsTracker.Tests.E2E.Pages;
using TrendsTracker.Tests.E2E.TestInfrastructure;
using MSTests = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrendsTracker.E2ETests
{
    [MSTests.TestClass]
    public class HomePageTests : E2ETestBase<HomePage>
    {
        protected override HomePage createPage(ApplicationRunner app) { return new HomePage(app.Driver); }

        [MSTests.TestMethod]
        public void user_enters_HomePage_and_should_see_website_name()
        {
            App.GoTo(page.PageUrl);
            page.AssertContainsText("body", "Trends Tracker");
        }
    }
}
