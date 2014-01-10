using System;
using System.Reflection;
using Headspring;
using Newtonsoft.Json;

namespace Core
{
    public class EnumerationConverter : JsonConverter
    {
        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            dynamic enumeration = value;
            writer.WriteStartObject();
            writer.WritePropertyName("value");
            writer.WriteValue(enumeration.Value);
            writer.WritePropertyName("displayName");
            writer.WriteValue(enumeration.DisplayName);
            writer.WriteEndObject();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var type = typeof (Enumeration<,>).MakeGenericType(objectType, typeof(int));
            var method = type.GetMethod("FromValue", BindingFlags.Public | BindingFlags.Static);
            var value = method.Invoke(null, new[] { (object)int.Parse((string)reader.Value) });
            return value;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof (Enumeration).IsAssignableFrom(objectType);
        }
    }
}