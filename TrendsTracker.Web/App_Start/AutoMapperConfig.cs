using AutoMapper;
using System.Collections.Generic;
using TrendsTracker.Entities;
using TrendsTracker.Web.Dto.Keywords;
using TrendsTracker.Web.Utilities;

namespace ProjectTrackerWeb
{
    public static class AutoMapperConfig
    {
        public static void Configure()
        {
            Mapper.CreateMap<Keyword, KeywordDto>();
            //.ForMember(dest => dest.UrlFriendlyName, m => m.MapFrom(src => new FriendlyUrlGenerator().ToFriendlyUrlName(src.Name)));
        }
    }
}