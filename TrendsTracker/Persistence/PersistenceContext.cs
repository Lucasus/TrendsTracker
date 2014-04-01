using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using TrendsTracker.Entities;
using TrendsTracker.Migrations;

namespace TrendsTracker.Persistence
{
    public class PersistenceContext : DbContext
    {
        public virtual DbSet<Keyword> Keywords { get; set; }

        public PersistenceContext()
            : base()
        {
            Database.SetInitializer<PersistenceContext>(new MigrateDatabaseToLatestVersion<PersistenceContext, MigrationConfiguration>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}
