using System.Data.Entity.Infrastructure;
using TrendsTracker.Persistence;

namespace TrendsTracker.Tests.E2E.TestInfrastructure
{
    public class DataDeleter
    {
        private string[] tableNames = new[] 
        { 
            "Keywords"
        };

        public void DeleteAllData()
        {
            foreach (var tableName in tableNames)
            {
                using (var context = new PersistenceContext())
                {
                    (context as IObjectContextAdapter).ObjectContext.ExecuteStoreCommand("TRUNCATE TABLE [" + tableName + "]");
                }
            }
        }
    }
}
