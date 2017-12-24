using Reactive.Bindings;
using Reactive.Bindings.Extensions;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Core.Utility;

namespace TrainTripThinker.ViewModel
{
    public class PeriodElementViewModel : ItineraryElementViewModel
    {
        public PeriodElementViewModel(PeriodElement model)
            : base(model)
        {
            Period = model.ObserveProperty(m => m.Period).ToReactiveProperty();
        }

        public ReactiveProperty<Period<Departure>> Period { get; }
    }
}