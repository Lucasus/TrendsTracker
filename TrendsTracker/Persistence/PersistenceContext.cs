using System.Data.Entity;
using TrendsTracker.Entities;

namespace TrendsTracker.Persistence
{
    public class PersistenceContext : DbContext
    {
        public virtual DbSet<Keyword> Keywords { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
