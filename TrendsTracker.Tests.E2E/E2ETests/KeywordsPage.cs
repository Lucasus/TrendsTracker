using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using TrendsTracker.Entities;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.Tests.E2E.Pages
{
    public class KeywordsPage : Page
    {
        public KeywordsPage(IWebDriver driver) : base(driver) { }
        public override string PageUrl { get { return "#/keywords/"; } }

        public void AssertKeywordNameIs(string keywordName)
        {
            PartialView.WaitFor("#keywordName");
            Assert.IsTrue(PartialView.Content.ContainsText(keywordName), PartialView.Content.ToString());
        }

        public void AssertAreDisplayed(IList<Keyword> keywords)
        {
            PartialView.WaitFor("#keywordsList");
            foreach (var keyword in keywords)
            {
                Assert.IsTrue(PartialView.Content.ContainsText(keyword.Name), PartialView.Content.ToString());
            }
        }

        public string GetHrefFor(Keyword keyword)
        {
            PartialView.WaitFor("#keywordsList");
            var a = Tag("a[href*=" + keyword.UrlFriendlyName + "]");// [@class='keywordUrl' and contains(., '" + keyword.Name + "')]");
            Assert.IsTrue(a.ContainsText(keyword.Name), a.ToString());
            return a.GetAttribute("href");
        }
    }
}
