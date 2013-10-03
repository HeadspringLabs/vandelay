using System.Collections.Generic;
using System.Threading.Tasks;
using Raven.Client;

namespace Core.Controllers
{
    using Models;

    public class ExportController : EntityController<Export> { }

    public class ImportController : EntityController<Import> { }

    public class LocationController : EntityController<Location> { }

    public class SalesAgentController : EntityController<SalesAgent> { }

    public abstract class EntityController<T> : StoreController where T : Entity
    {
        public Task<T> Get(int id)
        {
            using (Session = Store.OpenAsyncSession())
                return Session.LoadAsync<T>(id);
        }

        public Task<IList<T>> Get()
        {
            using (Session = Store.OpenAsyncSession())
                return Session.Query<T>().ToListAsync();
        }

        public async Task<T> Post(T entity)
        {
            return await Save(entity);
        }

        public async Task<T> Put(T entity)
        {
            return await Save(entity);
        }

        public void Delete(int id)
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
