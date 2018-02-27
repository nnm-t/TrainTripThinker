using System;
using System.Reactive.Disposables;
using System.Reactive.Linq;

using Reactive.Bindings.Extensions;

using TrainTripThinker.Core.Utility;

namespace TrainTripThinker.Core.Data
{
    public class PeriodElement : ItineraryElement, IDisposable
    {
        private readonly CompositeDisposable disposables;

        private Period<Departure> period;


        public PeriodElement(ItineraryElementDelegates delegates, Departure lastArrive = null) : base(delegates)
        {
            disposables = new CompositeDisposable();
            CreatePeriodInstance(lastArrive);
        }

        public PeriodElement()
        {
            disposables = new CompositeDisposable();
            CreatePeriodInstance();
        }

        ~PeriodElement()
        {
            Dispose();
        }

        /// <summary>
        /// 乗車～下車までの期間
        /// </summary>
        public Period<Departure> Period
        {
            get => period;
            set => SetProperty(ref period, value);
        }

        public void Dispose()
        {
            disposables.Dispose();
        }

        private void SubscribeBeginDateTimeMismatch()
        {
            Period.Begin.ObserveProperty(p => p.Date).Subscribe(dt =>
            {
                if (dt > Period.End.DateTime)
                {
                    Period.End.Date = dt;
                }
            }).AddTo(disposables);

            Period.Begin.ObserveProperty(p => p.Time).Subscribe(dt =>
            {
                if (dt > Period.End.DateTime)
                {
                    Period.End.Time = dt;
                }
            }).AddTo(disposables);
        }

        private void CreatePeriodInstance(Departure lastArrive = null)
        {
            Period = new Period<Departure>(new Departure(lastArrive), new Departure(lastArrive?.ExceptStation()));
            SubscribeBeginDateTimeMismatch();
        }
    }
}