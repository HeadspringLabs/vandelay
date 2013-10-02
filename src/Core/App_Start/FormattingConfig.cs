using System.Net.Http.Formatting;
using System.Web.Http;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace Core
{
    public static class FormattingConfig
    {
        private static readonly JsonSerializerSettings _serializerSettings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };

        public static void Register(HttpConfiguration config)
        {
            _serializerSettings.Converters.Insert(0, new EnumerationConverter());
            config.Formatters.Insert(0, new JsonMediaTypeFormatter { SerializerSettings = _serializerSettings });
        }
    }
}