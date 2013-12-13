using System;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.Controllers;
using Core.Models;
using Raven.Client;
using Raven.Client.Document;
using Raven.Client.Embedded;

namespace Core.Controllers
{
    public abstract class StoreController : ApiController
    {
        public IDocumentStore Store
        {
            get { return LazyDocStore.Value; }
        }

        private static readonly Lazy<IDocumentStore> LazyDocStore = new Lazy<IDocumentStore>(() =>
        {
            var documentStore = new DocumentStore { ConnectionStringName = "RavenDB" };
            documentStore.Initialize();
            return documentStore;
        });

        public IAsyncDocumentSession Session { get; set; }

        public async override Task<HttpResponseMessage> ExecuteAsync(HttpControllerContext controllerContext, CancellationToken cancellationToken)
        {
            using (Session = Store.OpenAsyncSession())
            {
                var result = await base.ExecuteAsync(controllerContext, cancellationToken);
                await Session.SaveChangesAsync();

                return result;
            }
        }

        protected async Task<T> Save<T>(T entity) where T : Entity
        {
            using (Session = Store.OpenAsyncSession())
            {
                await Session.StoreAsync(entity);

                return entity;
            }
        }
    }
}