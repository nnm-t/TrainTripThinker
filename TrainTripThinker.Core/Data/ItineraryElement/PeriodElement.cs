using System;

using TrainTripThinker.Core.Utility;

namespace TrainTripThinker.Core.Data
{
    public class PeriodElement : ItineraryElement
    {
        private Period<Departure> period;

        public PeriodElement(ItineraryElementDelegates delegates) : base(delegates)
        {
            Period = new Period<Departure>(new Departure(), new Departure());
        }

        /// <summary>
        /// 乗車～下車までの期間
        /// </summary>
        public Period<Departure> Period
        {
            get => period;
            set => SetProperty(ref period, value);
        }
    }
}