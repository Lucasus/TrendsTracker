using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendsTracker.Tests.E2E.TestInfrastructure
{
    public class Page
    {
        protected IWebDriver driver;

        public virtual string PageUrl { get { return ""; } }

        public Page(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void AssertContainsText(string selector, string text)
        {
            var domTag = driver.FindElement(By.CssSelector(selector));
            Assert.That(domTag.Text.Contains(text), Is.True);
        }

        public bool IsEmpty(string selector)
        {
            var domTag = driver.FindElement(By.CssSelector(selector));
            return String.IsNullOrEmpty(domTag.Text);
        }
    }
}
