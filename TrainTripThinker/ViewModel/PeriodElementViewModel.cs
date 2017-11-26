using Reactive.Bindings;
using Reactive.Bindings.Extensions;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Core.Utility;

namespace TrainTripThinker.ViewModel
{
    public abstract class PeriodElementViewModel : ItineraryElementViewModel
    {
        protected PeriodElementViewModel(PeriodElement model)
            : base(model)
        {
            Period = model.ObserveProperty(m => m.Period).ToReactiveProperty();
        }

        public ReactiveProperty<Period<Departure>> Period { get; }
    }
}