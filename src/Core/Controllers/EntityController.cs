using System.Collections.Generic;
using System.Threading.Tasks;
using Raven.Client;

namespace Core.Controllers
{
    using Models;

    public abstract class EntityController<T> : StoreController where T : Entity
    {
        public virtual Task<T> Get(int id)
        {
            using (Session = Store.OpenAsyncSession())
                return Session.LoadAsync<T>(id);
        }

        public virtual Task<IList<T>> Get()
        {
            using (Session = Store.OpenAsyncSession())
                return Session.Query<T>().ToListAsync();
        }

        public virtual async Task<T> Post(T entity)
        {
            return await Save(entity);
        }

        public virtual async Task<T> Put(T entity)
        {
            return await Save(entity);
        }

        public virtual void Delete(int id)
        {
            using (var session = Store.OpenSession())
            {
                var actual = session.Load<T>(id);
                session.Delete(actual);
                session.SaveChanges();
            }
        }
    }
}
