using Microsoft.VisualStudio.TestTools.UnitTesting;
using MvcRouteTester;
using MvcRouteTester.Fluent;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using TrendsTracker.Web;
using TrendsTracker.Web.Controllers;

namespace TrendsTracker.Tests.Unit.Routing
{
    [TestClass]
    public class KeywordsRoutingTests
    {
        private HttpConfiguration config;

        [TestInitialize]
        public void TestInitialize()
        {
            config = new HttpConfiguration();
            WebApiConfig.Register(config);
            config.EnsureInitialized();
        }

        [TestMethod, TestCategory(TestCategories.Routing)]
        public void Should_correctly_route_to_list_of_keywords()
        {
            config.ShouldMap("/api/keywords/?searchTerm=bla&sortType=x&page=3").To<KeywordsController>(HttpMethod.Get, x => x.Get("bla", "x", 3));
            config.ShouldMap("/api/keywords/?searchTerm=&sortType=").To<KeywordsController>(HttpMethod.Get, x => x.Get("", "", null));
        }
    }
}
