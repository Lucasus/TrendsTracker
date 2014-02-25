using System;
using MSTests = Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendsTracker.Tests.E2E.Extensions;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.E2ETests.TestInfrastructure
{
    [MSTests.TestClass]
    public class E2ETestsBase
    {
        private static ApplicationRunner app;

        protected static void classInitialize()
        {
            app = new ApplicationRunner();
        }

        protected static void classCleanup()
        {
            app.Dispose();
        }

        public ApplicationRunner App { get { return app; } }
    }
}
