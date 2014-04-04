using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TrendsTracker.Infrastructure;
using TrendsTracker.Web.Utilities;

namespace TrendsTracker.Entities
{
    public class Keyword : Entity
    {
        private string name;

        public string Name
        {
            get { return name; }
            set 
            { 
                name = value;
                UrlFriendlyName = new FriendlyUrlGenerator().ToFriendlyUrlName(name);
            }
        }

        public string UrlFriendlyName { get; private set; }
    }
}
