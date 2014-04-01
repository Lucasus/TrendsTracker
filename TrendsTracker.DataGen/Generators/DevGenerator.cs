using System.Data.Entity;

namespace TrendsTracker.DataGen
{
    public class DevGenerator : Generator
    {
        public DevGenerator(DbContext context) : base(context) { }

        public void Generate()
        {
            Save(new Keywords());
        }
    }
}
