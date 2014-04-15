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

        public IWebElement Element
        {
            get
            {
                return driver.FindElement(By.CssSelector(selector));
            }
        }

        public bool ContainsText(string text)
        {
            return Element.Text.Contains(text);
        }

        public bool IsEmpty()
        {
            return String.IsNullOrEmpty(Element.Text);
        }

        public string GetAttribute(string attributeName)
        {
            return Element.GetAttribute(attributeName);
        }
    }
}
