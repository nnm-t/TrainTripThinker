using System.Collections.Generic;
using System.Linq;

using Newtonsoft.Json;

namespace TrainTripThinker.Core
{
    public static class TttDocumentConverter
    {
        public static JsonConverter[] Create()
        {
            return CreateCollection().ToArray();
        }

        private static IEnumerable<JsonConverter> CreateCollection()
        {
            yield return new ItineraryElementConverter();
            yield return new TransportConverter();
        }
    }
}