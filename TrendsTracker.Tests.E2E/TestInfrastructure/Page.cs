using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendsTracker.Tests.E2E.Pages;

namespace TrendsTracker.Tests.E2E.TestInfrastructure
{
    public class Page
    {
        protected IWebDriver driver;
        private PartialView partialView;

        public PartialView PartialView { get { return partialView; } }

        public virtual string PageUrl { get { return ""; } }

        public Page(IWebDriver driver)
        {
            this.driver = driver;
            this.partialView = new PartialView(driver);
        }

        public Tag Tag(string selector)
        {
            return new Tag(driver, selector);
        }
    }
}
