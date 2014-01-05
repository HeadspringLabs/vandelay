using System;
using System.Linq;
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

	    private Random _random;

	    public HttpResponseMessage Post()
        {
			_random = new Random();

            using (var documentSession = Store.OpenSession())
            {
                _locations.ForEach(documentSession.Store);

	            foreach (var agent in _salesAgents)
	            {
					var exports = GetRandomExports(20).ToList();
					var imports = GetRandomImports(20).ToList();

					exports.ForEach(documentSession.Store);
					imports.ForEach(documentSession.Store);

					agent.Exports = exports;
					agent.Imports = imports;

					documentSession.Store(agent);
	            }

				documentSession.SaveChanges();
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

				var imports = session.Query<Import>();
				imports.ForEach(session.Delete);

                session.SaveChanges();
            }

            return new HttpResponseMessage(HttpStatusCode.OK);
        }

		private Export[] GetRandomExports(int count)
		{
			var exports = new Export[count];
			for (var i = 0; i < exports.Length; i++)
			{
				var jurisdiction = Jurisdiction.FromInt32(_random.Next(Jurisdiction.GetAll().Length) + 1);

				exports[i] = new Export
				{
					Price = (decimal)Math.Round(_random.NextDouble() * 5000, 2),
					Quantity = _random.Next(10000),
					Measure = Measure.FromInt32(_random.Next(Measure.GetAll().Length) + 1),
					To = jurisdiction,
					Name = string.Format("{0} to {1}", RandomGoodsName(), jurisdiction.DisplayName)
				};
			}

			return exports;
		}

		private Import[] GetRandomImports(int count)
		{
			var imports = new Import[count];
			for (var i = 0; i < imports.Length; i++)
			{
				var jurisdiction = Jurisdiction.FromInt32(_random.Next(Jurisdiction.GetAll().Length) + 1);

				imports[i] = new Import
				{
					Price = (decimal)Math.Round(_random.NextDouble() * 5000, 2),
					Quantity = _random.Next(10000),
					Type = ImportType.FromInt32(_random.Next(ImportType.GetAll().Length) + 1),
					From = jurisdiction,
					Name = string.Format("{0} from {1}", RandomGoodsName(), jurisdiction.DisplayName)
				};
			}

			return imports;
		}

		private string RandomGoodsName()
		{
			var goods = new[]
				{
					"Long Matches",
					"Chips, potato",
					"Chips, corn",
					"Diapers",
					"Toilet Paper",
					"Non-Fat Yogurt"
				};

			var randomIndex = _random.Next(goods.Length);
			return goods[randomIndex];
		}
    }
}