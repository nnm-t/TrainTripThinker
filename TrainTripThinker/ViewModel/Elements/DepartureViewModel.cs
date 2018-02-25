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

            // ViewModel -> Model
            Date.Subscribe(x => model.Date = x).AddTo(Disposables);
            Time.Subscribe(x => model.Time = x).AddTo(Disposables);
            Name.Subscribe(x => model.Name = x).AddTo(Disposables);
        }
        
        public ReactiveProperty<DateTime> Date { get; }

        public ReactiveProperty<DateTime> Time { get; }

        public ReactiveProperty<string> Name { get; }

        public ReactiveProperty<PlatformViewModel> Platform { get; }
    }
}