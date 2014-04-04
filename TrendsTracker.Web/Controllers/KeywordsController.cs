using System.Linq;
using System.Collections.Generic;
using System.Web.Http;
using TrendsTracker.Entities;
using TrendsTracker.Reps;
using TrendsTracker.Web.Utilities;
using TrendsTracker.Web.Dto.Keywords;
using System.Net.Http;
using System.Net;
using TrendsTracker.Infrastructure;

namespace TrendsTracker.Web.Controllers
{
    [RoutePrefix("api/keywords")]
    public class KeywordsController : ApiController
    {
        private KeywordRepository keywordRepository;
        private UnitOfWork unitOfWork;

        public KeywordsController(KeywordRepository keywordRepository, UnitOfWork unitOfWork)
        {
            this.keywordRepository = keywordRepository;
            this.unitOfWork = unitOfWork;
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

        [Route("")]
        public KeywordDto Get(int id)
        {
            return keywordRepository.GetById(id).ToViewModel<KeywordDto>();
        }

        [HttpPost, Route("create")]
        public virtual HttpResponseMessage ProductCreate(KeywordDto model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            unitOfWork.Do(work =>
            {
                var entity = new Keyword();
                entity.Name = model.Name;
                keywordRepository.Add(entity);
            });
            return Request.CreateResponse(HttpStatusCode.OK);
        }

        [HttpPost, Route("{id}/update")]
        public virtual HttpResponseMessage ProductUpdate(KeywordDto model)
        {
            if (!ModelState.IsValid)
            {
                return Request.CreateResponse(HttpStatusCode.BadRequest);
            }
            unitOfWork.Do(work =>
            {
                var entity = keywordRepository.GetById(model.Id);
                entity.Name = model.Name;
                keywordRepository.Update(entity);
            });
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}