using System;
using System.Net;


namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 乗り物の行程
    /// </summary>
    /// <inheritdoc cref="PeriodElement"/>
    public class TransportElement : PeriodElement
    {
        public TransportElement(TransportBase transport, ItineraryElementDelegates delegates, Departure departure = null)
            : base(delegates, departure)
        {
            Transport = transport;
        }

        public TransportElement()
        {
            
        }

        /// <summary>
        /// 乗り物
        /// </summary>
        public TransportBase Transport { get; set; }
    }
}