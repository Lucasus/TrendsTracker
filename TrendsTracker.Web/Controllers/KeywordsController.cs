using System.Linq;
using System.Collections.Generic;
using System.Web.Http;
using TrendsTracker.Entities;
using TrendsTracker.Reps;
using TrendsTracker.Web.Utilities;
using TrendsTracker.Web.Dto.Keywords;

namespace TrendsTracker.Web.Controllers
{
    [RoutePrefix("api/keywords")]
    public class KeywordsController : ApiController
    {
        private KeywordRepository keywordRepository;

        public KeywordsController(KeywordRepository keywordRepository)
        {
            this.keywordRepository = keywordRepository;
        }

        [Route("")]
        public IEnumerable<KeywordDto> Get()
        {
            return keywordRepository.GetAll().Select(x => x.ToViewModel<KeywordDto>());
        }

        [Route("{urlFriendlyName}")]
        public KeywordDto Get(string urlFriendlyName)
        {
            return keywordRepository.GetByUrlFriendlyName(urlFriendlyName).ToViewModel<KeywordDto>();
        }
    }
}