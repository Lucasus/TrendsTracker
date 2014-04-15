using NUnit.Framework;
using System;
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
    public class KeywordsPageTests : E2ETestBase<KeywordsPage>
    {
        protected override KeywordsPage createPage(ApplicationRunner app) { return new KeywordsPage(app.Driver); }

        [MSTests.TestMethod]
        public void user_can_enter_keywords_page_and_see_keywords_list()
        {
            App.GoTo(page.PageUrl);
            page.AssertAreDisplayed(TestData.Keywords);
        }

        [MSTests.TestMethod]
        public void user_can_click_on__keyword_name_and_see_keyword_details()
        {
            var testedKeyword = TestData.Keywords[2];

            App.GoTo(page.PageUrl);

            var url = page.GetHrefFor(testedKeyword);
            Assert.IsTrue(url.Contains(testedKeyword.UrlFriendlyName));

            var uri = new Uri(url);
            App.GoTo(uri.Fragment);

            page.AssertKeywordNameIs(testedKeyword.Name);
        }
    }
}
