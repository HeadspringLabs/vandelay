namespace Core.Controllers
{
    using System.Collections;
    using System.Net;
    using System.Net.Http;
    using System.Web.Http;
    using Headspring;
    using System.Linq;
    using Models;

    public class MeasureController : EnumerationController<Measure> { }

    public class JurisdictionController : EnumerationController<Jurisdiction> { }

    public abstract class EnumerationController<T> : ApiController where T : Enumeration<T>
    {
        public IEnumerable Get()
        {
            return Enumeration<T>.GetAll()
                .Select(x => new { x.Value, x.DisplayName });
        }

        public object Get(int id)
        {
            var @enum = Enumeration<T>.FromValue(id);
            return new { @enum.Value, @enum.DisplayName };
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