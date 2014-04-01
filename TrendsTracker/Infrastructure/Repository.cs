using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TrendsTracker.Persistence;

namespace TrendsTracker.Infrastructure
{
    public abstract class Repository<T>
        where T: Entity, new()
    {
        protected PersistenceContext context;

        public Repository(PersistenceContext context)
        {
            this.context = context;
        }

        public virtual IQueryable<T> GetAll()
        {
            return context.Set<T>();
        }

        public virtual T GetById(int id)
        {
            return context.Set<T>().Find(id);
        }

        public void Add(T entity)
        {
            context.Set<T>().Add(entity);
            context.SaveChanges();
        }

        public void Update(T entity)
        {
            context.Entry(entity).State = EntityState.Modified;
            context.SaveChanges();
        }

        public virtual void Delete(int id)
        {
            var entity = new T() { Id = id };
            context.Entry(entity).State = EntityState.Deleted;
            context.SaveChanges();
        }

    }
}
