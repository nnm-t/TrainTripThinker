using System;

using Newtonsoft.Json.Linq;

using TrainTripThinker.Core.Data;

namespace TrainTripThinker.Core
{
    public class TransportConverter : JsonCreationConverter<TransportBase>
    {
        protected override TransportBase Create(Type objectType, JObject jObject)
        {
            if (FieldExists("Class", jObject))
            {
                return new Train();
            }

            throw new InvalidOperationException("TransportConverterに型判定が存在しません。");
        }
    }
}