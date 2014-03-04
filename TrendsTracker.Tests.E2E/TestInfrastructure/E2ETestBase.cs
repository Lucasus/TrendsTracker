using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.E2ETests
{
    [TestClass]
    public abstract class E2ETestBase<T>: WebTestBase
        where T: Page
    {
        protected T page;

        protected abstract T createPage(ApplicationRunner app);

        [TestInitialize]
        public void TestInitialize()
        {
            new DataDeleter().DeleteAllData();
            page = createPage(App);
        }
    }
}
