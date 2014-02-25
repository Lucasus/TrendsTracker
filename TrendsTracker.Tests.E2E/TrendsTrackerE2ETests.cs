using TrendsTracker.E2ETests.TestInfrastructure;
using MSTests = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrendsTracker.E2ETests
{
    [MSTests.TestClass]
    public class TrendsTrackerE2ETests : E2ETestsBase
    {
        private string homePageUrl = "";

        [MSTests.ClassInitialize]
        public static void ClassInitialize(MSTests.TestContext context) { classInitialize(); }

        [MSTests.ClassCleanup] 
        public static void ClassCleanup() { classCleanup(); }

        [MSTests.TestMethod]
        public void user_enters_HomePage_and_sees_website_name()
        {
            App.GoTo(homePageUrl);
            App.pageContainsText("Trends Tracker");
        }
    }
}
