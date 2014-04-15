using System.Threading;
using TrendsTracker.Entities;
using TrendsTracker.Infrastructure;
using TrendsTracker.Reps;
using TrendsTracker.Tests.E2E.Pages;
using TrendsTracker.Tests.E2E.TestInfrastructure;
using MSTests = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrendsTracker.E2ETests
{
    [MSTests.TestClass]
    public class KeywordPageTests : E2ETestBase<KeywordPage>
    {
        protected override KeywordPage createPage(ApplicationRunner app) { return new KeywordPage(app.Driver); }

        [MSTests.TestMethod]
        public void user_enters_keyword_details_page_and_sees_keyword_name()
        {
            App.GoTo(page.PageUrl + "java");
            page.AssertKeywordNameIs("Java");
        }
    }
}
