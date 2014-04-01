using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendsTracker.Infrastructure;

namespace TrendsTracker.Entities
{
    public class Keyword : Entity
    {
        public string Name { get; set; }
        public string UrlFriendlyName { get; set; }
    }
}
