using AutoMapper;
using System.Collections.Generic;
using TrendsTracker.Entities;
using TrendsTracker.Web.Dto.Keywords;

namespace ProjectTrackerWeb
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.CreateMap<Keyword, KeywordDto>();
        }
    }
}