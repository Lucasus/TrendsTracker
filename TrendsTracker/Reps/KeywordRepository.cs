using System.Collections.Generic;
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

        public IList<Keyword> Get(string searchTerm, string sortType, int pageSize, int page)
        {
            var products = context.Keywords.Where(x => x.Name.Contains(searchTerm));
            switch (sortType)
            {
                case "name_asc":
                    products = products.OrderBy(x => x.Name);
                    break;
                case "name_desc":
                    products = products.OrderByDescending(x => x.Name);
                    break;
                default:
                    products = products.OrderBy(x => x.Id);
                    break;
            }
            products = products.Skip((page - 1) * pageSize).Take(pageSize);
            return products.ToList();
        }

        public int Count(string searchTerm)
        {
            return context.Keywords.Where(x => x.Name.Contains(searchTerm)).Count();
        }
    }
}
