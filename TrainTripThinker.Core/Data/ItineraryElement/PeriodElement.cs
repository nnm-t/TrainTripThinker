using System;

using TrainTripThinker.Core.Utility;

namespace TrainTripThinker.Core.Data
{
    public class PeriodElement : ItineraryElement
    {
        private Period<Departure> period;

        public PeriodElement(ItineraryElementDelegates delegates, DateTime beginTime) : base(delegates)
        {
            CreatePeriodInstance(beginTime);
        }

        public PeriodElement(ItineraryElementDelegates delegates) : base(delegates)
        {
            CreatePeriodInstance();
        }

        public PeriodElement()
        {
            CreatePeriodInstance();
        }

        /// <summary>
        /// 乗車～下車までの期間
        /// </summary>
        public Period<Departure> Period
        {
            get => period;
            set => SetProperty(ref period, value);
        }

        private void CreatePeriodInstance()
        {
            Period = new Period<Departure>(new Departure(), new Departure());
        }

        private void CreatePeriodInstance(DateTime begin)
        {
            Period = new Period<Departure>(new Departure(begin), new Departure(begin));
        }
    }
}