using TrendsTracker.Entities;

namespace TrendsTracker.DataGen
{
    public class Keywords : Data<Keyword>
    {
        public static Keyword Keyword1 = new Keyword { Name = "java" };
        public static Keyword Keyword2 = new Keyword { Name = "C#" };
        public static Keyword Keyword3 = new Keyword { Name = "ASP.NET MVC" };
    }
}
