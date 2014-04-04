using System.Collections.Generic;
using TrendsTracker.Entities;

namespace TrendsTracker.DataGen
{
    public class Keywords : Data<Keyword>
    {
        public static Keyword Keyword1 = new Keyword { Name = "java" };
        public static Keyword Keyword2 = new Keyword { Name = "C#" };
        public static Keyword Keyword3 = new Keyword { Name = "ASP.NET MVC" };

        public override IList<Keyword> GetData()
        {
            var products = new List<Keyword>();
            for (int i = 0; i < 15; ++i)
            {
                products.Add(new Keyword() { Name = "Keyword" + i });
            }
            return products;
        }

    }
}
