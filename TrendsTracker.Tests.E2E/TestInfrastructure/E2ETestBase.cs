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

        public void FixEfProviderServicesProblem()
        {
            //Fixes problem in TeamCity builds:

            //The Entity Framework provider type 'System.Data.Entity.SqlServer.SqlProviderServices, EntityFramework.SqlServer'
            //for the 'System.Data.SqlClient' ADO.NET provider could not be loaded. 
            //Make sure the provider assembly is available to the running application. 
            //See http://go.microsoft.com/fwlink/?LinkId=260882 for more information.
            var instance = System.Data.Entity.SqlServer.SqlProviderServices.Instance;
        }
    }
}
