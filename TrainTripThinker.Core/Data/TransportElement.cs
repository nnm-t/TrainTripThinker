using TrainTripThinker.Core.Utility;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 行程表の乗り物要素
    /// </summary>
    /// <inheritdoc cref="ItineraryElement"/>
    public class TransportElement : ItineraryElement
    {
        /// <summary>
        /// 乗車～下車までの期間
        /// </summary>
        public Period<Departure> Period { get; set; }

        /// <summary>
        /// 乗り物
        /// </summary>
        public Transport Transport { get; set; }
    }
}