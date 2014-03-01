using TrendsTracker.Entities;
using TrendsTracker.Reps;
using MSTests = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrendsTracker.E2ETests
{
    [MSTests.TestClass]
    public class KeywordDetailsTests : E2ETestBase
    {
        [MSTests.TestMethod]
        public void user_enters_keyword_details_page_and_sees_keyword_name()
        {

            new KeywordRepository().AddKeyword(new Keyword() { Name = "Java", UrlFriendlyName = "java" });
            App.GoTo("#/keyword/java");
            App.assertContainsText("Java");
        }
    }
}
