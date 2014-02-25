using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrendsTracker.Tests.E2E.Extensions
{
    public static class WebDriverExtensions
    {
        public static bool ContainsText(this IWebDriver driver, string text)
        {
            var bodyTag = driver.FindElement(By.TagName("body"));
            return bodyTag.Text.Contains(text);
        }         
    }
}
