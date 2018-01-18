using System;
using System.Reactive.Linq;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Core.Data;

namespace TrainTripThinker.ViewModel
{
    public class DepartureViewModel : ViewModelBase
    {
        public DepartureViewModel(Departure model)
        {
            Date = model.ObserveProperty(m => m.Date).ToReactiveProperty();
            Time = model.ObserveProperty(m => m.Time).ToReactiveProperty();
            Name = model.ObserveProperty(m => m.Name).ToReactiveProperty();

            Platform = model.ObserveProperty(m => m.Platform).Select(p => new PlatformViewModel(p))
                .ToReactiveProperty();
        }
        
        public ReactiveProperty<DateTime> Date { get; }

        public ReactiveProperty<DateTime> Time { get; }

        public ReactiveProperty<string> Name { get; }

        public ReactiveProperty<PlatformViewModel> Platform { get; }
    }
}