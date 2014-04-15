using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.Tests.E2E.Pages
{
    public class KeywordPage : Page
    {
        public KeywordPage(IWebDriver driver) : base(driver) { }
        public override string PageUrl { get { return "#/keywords/"; } }

        public void AssertKeywordNameIs(string keywordName)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(x => { return !Tag("#mainView").IsEmpty() && !Tag("#keywordName").IsEmpty(); });
            Assert.IsTrue(Tag("#mainView").ContainsText(keywordName));
        }
    }
}
