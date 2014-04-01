using System.Linq;
using System.Collections.Generic;
using System.Web.Http;
using TrendsTracker.Entities;
using TrendsTracker.Reps;
using TrendsTracker.Web.Utilities;
using TrendsTracker.Web.Dto.Keywords;

namespace TrendsTracker.Web.Controllers
{
    public class KeywordsController : ApiController
    {
        private KeywordRepository keywordRepository;

        public KeywordsController(KeywordRepository keywordRepository)
        {
            this.keywordRepository = keywordRepository;
        }

        public IEnumerable<KeywordDto> Get()
        {
            return keywordRepository.GetAll().Select(x => x.ToViewModel<KeywordDto>());
        }

        public KeywordDto Get(string keywordName)
        {
            return keywordRepository.GetByUrlName(keywordName).ToViewModel<KeywordDto>();
        }
    }
}