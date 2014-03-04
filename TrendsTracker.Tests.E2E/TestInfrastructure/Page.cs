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

        public Tag Tag(string selector)
        {
            return new Tag(driver, selector);
        }
    }
}
