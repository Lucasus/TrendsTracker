using System.Linq;
using TrendsTracker.Entities;
using TrendsTracker.Infrastructure;
using TrendsTracker.Persistence;

namespace TrendsTracker.Reps
{
    public class KeywordRepository : Repository<Keyword>
    {
        public KeywordRepository(PersistenceContext context) : base(context) { }

        public Keyword GetByUrlFriendlyName(string urlFriendlyName)
        {
            return context.Keywords.Where(x => x.UrlFriendlyName == urlFriendlyName).SingleOrDefault();
        }
    }
}
