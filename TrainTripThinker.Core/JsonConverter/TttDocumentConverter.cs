using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TrainTripThinker.Core
{
    public static class TttDocumentConverter
    {
        public static JsonConverter[] CreateReadConverters()
        {
            return CreateReadConverterCollection().ToArray();
        }

        public static JsonConverter[] CreateWriteConverters()
        {
            return CreateWriteConverterCollection().ToArray();
        }

        private static IEnumerable<JsonConverter> CreateReadConverterCollection()
        {
            yield return new ItineraryElementConverter();
            yield return new TransportConverter();
            yield return new VersionConverter();
        }

        private static IEnumerable<JsonConverter> CreateWriteConverterCollection()
        {
            yield return new VersionConverter();
        }
    }
}