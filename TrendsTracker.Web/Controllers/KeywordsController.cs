using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using TrendsTracker.Entities;
using TrendsTracker.Reps;

namespace TrendsTracker.Web.Controllers
{
    public class KeywordsController : ApiController
    {
        private KeywordRepository keywordRepository = new KeywordRepository();

        // GET api/keywords/x
        public Keyword Get(string keywordName)
        {
            return keywordRepository.GetByUrlName(keywordName);
        }
    }
}