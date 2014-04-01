using System.Collections.Generic;
using System.Web.Http;
using TrendsTracker.Entities;
using TrendsTracker.Reps;

namespace TrendsTracker.Web.Controllers
{
    public class KeywordsController : ApiController
    {
        private KeywordRepository keywordRepository;

        public KeywordsController(KeywordRepository keywordRepository)
        {
            this.keywordRepository = keywordRepository;
        }

        public IEnumerable<Keyword> Get()
        {
            return keywordRepository.GetAll();
        }

        public Keyword Get(string keywordName)
        {
            return keywordRepository.GetByUrlName(keywordName);
        }
    }
}