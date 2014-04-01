using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TrendsTracker.Infrastructure;

namespace TrendsTracker.DataGen
{
    public class Generator
    {
        private DbContext context;

        public Generator(DbContext context)
        {
            this.context = context;
        }

        public void Save<T>(Data<T> data)
            where T: Entity, new()
        {
            var entities = data.GetType()
                          .GetFields(BindingFlags.Public | BindingFlags.Static)
                          .Where(f => f.FieldType == typeof(T))
                          .Select(prop => (T)prop.GetValue(null)).ToList();

            var additionalEntites = data.GetData();
            if (additionalEntites != null)
            {
                entities = entities.Union(additionalEntites).ToList();
            }

            foreach (var ent in entities)
            {
                context.Set<T>().Add(ent);
            }
            Console.Write("Creating " + typeof(T).Name + "... ");
            context.SaveChanges();
            Console.WriteLine(" DONE");
        }
    }
}
