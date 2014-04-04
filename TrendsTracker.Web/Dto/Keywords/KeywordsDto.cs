using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrendsTracker.Web.Dto.Keywords
{
    public class KeywordsDto
    {
        public IEnumerable<KeywordDto> Items { get; set; }
        public string SearchTerm { get; set; }
        public int PageSize { get; set; }
        public int Page { get; set; }
        public string SortType { get; set; }
        public int TotalRecordsCount { get; set; }
    }
}