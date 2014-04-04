using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TrendsTracker.Web.Dto.Keywords
{
    public class KeywordDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UrlFriendlyName { get; set; }
    }
}