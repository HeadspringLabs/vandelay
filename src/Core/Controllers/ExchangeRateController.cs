using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Core.Controllers
{
    using Models;

    public class ExchangeRateController : ApiController
    {
        public ExchangeRate Get(Currency from, Currency to)
        {
            return new ExchangeRate { From = from, To = to, Rate = 0.125m };
        }

        public HttpResponseMessage Post()
        {
            return new HttpResponseMessage(HttpStatusCode.Forbidden);
        }

        public HttpResponseMessage Put()
        {
            return new HttpResponseMessage(HttpStatusCode.Forbidden);
        }

        public HttpResponseMessage Delete()
        {
            return new HttpResponseMessage(HttpStatusCode.Forbidden);
        }
    }
}