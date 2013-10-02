using System.Collections.Generic;
using System.Threading.Tasks;
using Raven.Client;

namespace Core.Controllers
{
    using Models;

    public class TestController : StoreController
    {
        public Task<IList<Export>> Get()
        {
            using (Session = Store.OpenAsyncSession())
            {
                return Session.Query<Export>().ToListAsync();
            }
        }

        public async Task<Export> Post(Export export)
        {
            using (Session = Store.OpenAsyncSession())
            {
                await Session.StoreAsync(export);

                return export;
            }
        }
    }
}
