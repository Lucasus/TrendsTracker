using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.E2ETests
{
    [TestClass]
    public partial class E2ETestBase
    {
        private static ApplicationRunner app;

        public ApplicationRunner App { get { return app; } }

        [AssemblyInitialize()]
        public static void AssemblyInit(TestContext context)
        {
            app = new ApplicationRunner();
        }

        [AssemblyCleanup()]
        public static void AssemblyCleanup()
        {
            app.Dispose();
        }

        [TestInitialize]
        public void TestInitialize()
        {
            new DataDeleter().DeleteAllData();
        }
    }
}
