using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.Tests.E2E.Pages
{
    public class HomePage : Page
    {
        public HomePage(IWebDriver driver) : base(driver) { }

        public override string PageUrl { get { return ""; } }
    }
}
