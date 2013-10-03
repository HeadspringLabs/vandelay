using System.Net;
using System.Net.Http;
using Core.Extensions;
using Core.Models;

namespace Core.Controllers
{
    public class TestDataController : StoreController
    {
        private static readonly Location[] _locations = new[] {
            new Location { Name = "Frank & Estelle Imports", Address = new Address { Address1 = "1344 Queens Boulevard", City = "New York", State = "NY", Country = "USA"} },
            new Location { Name = "Exports by Morty", Address = new Address { Address1 = "2290 Cobb Ave", City = "Del Boca Vista", State = "FL" } },
            new Location { Name = "Vandelay Industries", Address = new Address { Address1 = "3100 W 45th St", Address2 = "Apt 5B", City = "New York", State = "NY" } },
        };

        private static readonly SalesAgent[] _salesAgents = new[] {
            new SalesAgent { Name = "Art Vandelay", Location = _locations[0] },
            new SalesAgent { Name = "Biff Loman", Location = _locations[0] },
            new SalesAgent { Name = "H.E. Pennpacker", Location = _locations[1] },
            new SalesAgent { Name = "Kal Varnsen", Location = _locations[2] },
            new SalesAgent { Name = "Dr. Martin van Nostrand", Location = _locations[2] },
            new SalesAgent { Name = "Lloyd Braun", Location = _locations[2] },
        };

        private static readonly Export[] _exports = new[] {
            new Export { Name = "Long Matches", To = Jurisdiction.Canada, Price = 240m, Quantity = 6, Measure = Measure.Crate },
            new Export { Name = "Chips, potato", To = Jurisdiction.France, Price = 60m, Quantity = 4, Measure = Measure.InsulatedContainer },
            new Export { Name = "Chips, corn", To = Jurisdiction.Finland, Price = 40m, Quantity = 4, Measure = Measure.InsulatedContainer },
            new Export { Name = "Diapers", To = Jurisdiction.Spain, Price = 12500m, Quantity = 1, Measure = Measure.Container },
            new Export { Name = "Toilet Paper", To = Jurisdiction.Canada, Price = 300m, Quantity = 3, Measure = Measure.BulkContainer },
            new Export { Name = "Non-Fat Yogurt", To = Jurisdiction.Mexico, Price = 60m, Quantity = 2, Measure = Measure.Drum },
            new Export { Name = "Space Pens", To = Jurisdiction.Japan, Price = 8575m, Quantity = 144, Measure = Measure.WoodenBox },
        };

        public HttpResponseMessage Post()
        {
            using (Session = Store.OpenAsyncSession())
            {
                _locations.ForEach(x => Session.StoreAsync(x));
                _salesAgents.ForEach(x => Session.StoreAsync(x));
                _exports.ForEach(x => Session.StoreAsync(x));

                Session.SaveChangesAsync();
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

        public HttpResponseMessage Delete()
        {
            using (var session = Store.OpenSession())
            {
                var locations = session.Query<Location>();
                locations.ForEach(session.Delete);

                var salesAgents = session.Query<SalesAgent>();
                salesAgents.ForEach(session.Delete);

                var exports = session.Query<Export>();
                exports.ForEach(session.Delete);

                session.SaveChanges();
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }
    }
}