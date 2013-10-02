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
            writer.WriteValue(enumeration.DisplayName as string);
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            var type = typeof (Enumeration<,>).MakeGenericType(objectType, typeof(int));
            var method = type.GetMethod("Parse", BindingFlags.Public | BindingFlags.Static);
            var value = method.Invoke(null, new[] { reader.Value });
            return value;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof (Enumeration).IsAssignableFrom(objectType);
        }
    }
}