using System.Collections.Generic;
using TrendsTracker.Infrastructure;

namespace TrendsTracker.DataGen
{
    public class Data<T> where T : Entity, new() 
    {
        public virtual IList<T> GetData() { return null; }
    }

}
