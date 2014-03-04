using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendsTracker.Tests.E2E.TestInfrastructure
{
    public class Tag
    {
        private string selector;
        protected IWebDriver driver;

        public Tag(IWebDriver driver, string selector)
        {
            this.selector = selector;
            this.driver = driver;
        }

        public bool ContainsText(string text)
        {
            return driver.FindElement(By.CssSelector(selector)).Text.Contains(text);
        }

        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(driver.FindElement(By.CssSelector(selector)).Text);
        }
    }
}
