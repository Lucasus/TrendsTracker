using MSTests = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrendsTracker.E2ETests
{
    [MSTests.TestClass]
    public class HomePageTests : E2ETestBase
    {
        private string homePageUrl = "";

        [MSTests.TestMethod]
        public void user_enters_HomePage_and_should_see_website_name()
        {
            App.GoTo(homePageUrl);
            App.assertContainsText("Trends Tracker");
        }
    }
}
