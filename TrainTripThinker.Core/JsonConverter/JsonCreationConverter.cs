using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
// ReSharper disable StyleCop.SA1600

namespace TrainTripThinker.Core
{
    public static class JsonCreationConverter
    {
        public static JsonReader CopyReaderForObject(JsonReader reader, JObject jObject)
        {
            JsonReader jObjectReader = jObject.CreateReader();
            jObjectReader.Culture = reader.Culture;
            jObjectReader.DateFormatString = reader.DateFormatString;
            jObjectReader.DateParseHandling = reader.DateParseHandling;
            jObjectReader.DateTimeZoneHandling = reader.DateTimeZoneHandling;
            jObjectReader.FloatParseHandling = reader.FloatParseHandling;
            jObjectReader.MaxDepth = reader.MaxDepth;
            jObjectReader.SupportMultipleContent = reader.SupportMultipleContent;

            return jObjectReader;
        }
    }

    public abstract class JsonCreationConverter<T> : JsonConverter
    {
        public override bool CanWrite => false;

        public override void WriteJson(JsonWriter writer, object value, JsonSerializer serializer)
        {
            throw new NotImplementedException();
        }

        public override object ReadJson(JsonReader reader, Type objectType, object existingValue, JsonSerializer serializer)
        {
            if (reader.TokenType == JsonToken.Null)
            {
                return null;
            }

            JObject jObject = JObject.Load(reader);

            T target = Create(objectType, jObject);

            using (JsonReader jObjectReader = JsonCreationConverter.CopyReaderForObject(reader, jObject))
            {
                serializer.Populate(jObjectReader, target);
            }

            return target;
        }

        public override bool CanConvert(Type objectType)
        {
            return typeof(T).IsAssignableFrom(objectType);
        }

        protected abstract T Create(Type objectType, JObject jObject);

        protected bool FieldExists(string fieldName, JObject jObject)
        {
            return jObject[fieldName] != null;
        }
    }
}