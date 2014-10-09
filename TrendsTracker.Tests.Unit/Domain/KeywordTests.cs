using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendsTracker.Entities;

namespace TrendsTracker.Tests.Unit
{
    [TestClass]
    public class KeywordTests
    {
        [TestMethod, TestCategory(TestCategories.Domain)]
        public void Should_correctly_initialize_url_friendly_name()
        {
            var keyword = new Keyword() { Name = "C# friendly" };
            Assert.AreEqual("csharp-friendly", keyword.UrlFriendlyName);
        }
    }
}
