using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendsTracker.DataGen;
using TrendsTracker.Entities;
using TrendsTracker.Infrastructure;
using TrendsTracker.Persistence;
using TrendsTracker.Reps;
using TrendsTracker.Tests.E2E;
using MSTests = Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TrendsTracker.Tests.E2E.TestInfrastructure
{
    public class TestData
    {
        public static IList<Keyword> Keywords { get; set; }

        public static void CreateBasicDataStructure()
        {
            var dbContext = new PersistenceContext();
            new DbMigrator(new MigrationConfiguration()).Update();
            new DbDataDeleter(dbContext).DeleteAllData();

            Keywords = new List<Keyword>()
            {
                new Keyword() { Name = "Java" },
                new Keyword() { Name = "CSharp" },
                new Keyword() { Name = "ASP.NET MVC" },
            };

            new UnitOfWork(dbContext).Do(work =>
            {
                foreach (var keyword in Keywords)
                {
                    new KeywordRepository(dbContext).Add(keyword);
                }
            });
            
        }
    }
}
