using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.Tests.E2E.Pages
{
    public class PartialView
    {
        private IWebDriver driver;

        public PartialView(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void WaitFor(string selector)
        {
            new WebDriverWait(driver, TimeSpan.FromSeconds(10)).Until(x =>
            {
                return !Content.IsEmpty() && !tag(selector).IsEmpty();
            });
        }

        public Tag Content
        {
            get
            {
                return tag("#mainView");
            }
        }

        private Tag tag(string selector)
        {
            return new Tag(driver, selector);
        }

    }
}
