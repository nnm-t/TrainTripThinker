using System.Reactive.Linq;
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
            Period = model.ObserveProperty(m => m.Period)
                .Select(p =>
                    new Period<DepartureViewModel>(new DepartureViewModel(p.Begin), new DepartureViewModel(p.End)))
                .ToReactiveProperty();
        }

        public ReactiveProperty<Period<DepartureViewModel>> Period { get; }
    }
}