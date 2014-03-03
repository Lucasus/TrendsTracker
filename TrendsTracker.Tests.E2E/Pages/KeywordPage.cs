using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.Tests.E2E.Pages
{
    public class KeywordPage : Page
    {
        protected string keywordNameCssSelector = ".keyword-name";

        public KeywordPage(IWebDriver driver) : base(driver) { }

        public override string PageUrl { get { return "#/keyword/"; } }

        public void AssertKeywordNameIs(string keywordName)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(x => { return !IsEmpty(".mainView"); });
            AssertContainsText(".mainView", keywordName);
        }
    }
}
