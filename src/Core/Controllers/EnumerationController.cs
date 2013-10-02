using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Headspring;

namespace Core.Controllers
{
    using Models;

    public class JurisdictionController : EnumerationController<Jurisdiction> { }

    public abstract class EnumerationController<T> : ApiController where T : Enumeration<T>
    {
        public IEnumerable<T> Get()
        {
            return Enumeration<T>.GetAll();
        }

        public T Get(int id)
        {
            return Enumeration<T>.FromValue(id);
        }

        public HttpResponseMessage Delete()
        {
            return new HttpResponseMessage(HttpStatusCode.Forbidden);
        }

        public HttpResponseMessage Put()
        {
            return new HttpResponseMessage(HttpStatusCode.Forbidden);
        }
    }
}