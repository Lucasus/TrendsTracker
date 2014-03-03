using Microsoft.VisualStudio.TestTools.UnitTesting;
using TrendsTracker.Tests.E2E.TestInfrastructure;

namespace TrendsTracker.E2ETests
{
    [TestClass]
    public abstract class WebTestBase
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
    }
}
