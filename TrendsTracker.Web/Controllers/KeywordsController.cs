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
        public KeywordsDto Get(string searchTerm, string sortType, int page = 1)
        {
            int pageSize = 10;

            return new KeywordsDto()
            {
                Items =  keywordRepository.Get(searchTerm ?? "", sortType ?? "", pageSize, page).Select(x => x.ToViewModel<KeywordDto>()),
                SearchTerm = searchTerm,
                PageSize = pageSize,
                SortType = sortType,
                Page = page,
                TotalRecordsCount = keywordRepository.Count(searchTerm ?? "")
            };
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

        [HttpPost]
        [Route("")]
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

        [HttpPost]
        [Route("{id}")]
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

        [HttpDelete]
        [Route("{id}")]
        public virtual HttpResponseMessage ProductDelete(int id)
        {
            unitOfWork.Do(work =>
            {
                keywordRepository.Delete(id);
            });
            return Request.CreateResponse(HttpStatusCode.OK);
        }

    }
}