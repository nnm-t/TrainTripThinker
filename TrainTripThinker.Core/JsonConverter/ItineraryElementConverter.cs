using System;

using Newtonsoft.Json.Linq;

using TrainTripThinker.Core.Data;

namespace TrainTripThinker.Core
{
    public class ItineraryElementConverter : JsonCreationConverter<ItineraryElement>
    {
        protected override ItineraryElement Create(Type objectType, JObject jObject)
        {
            if (FieldExists("Transport", jObject))
            {
                return new TransportElement();
            }

            if (FieldExists("Period", jObject))
            {
                return new PeriodElement();
            }

            return new ItineraryElement();
        }
    }
}