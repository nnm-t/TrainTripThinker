using System;
using System.Reactive.Disposables;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Core.Data;

namespace TrainTripThinker.ViewModel
{
    public class TransportNumberViewModel : ViewModelBase
    {
        public TransportNumberViewModel(TransportNumber model)
        {
            Prefix = model.ObserveProperty(m => m.Prefix).ToReactiveProperty();
            Number = model.ObserveProperty(m => m.Number).ToReactiveProperty();
            Suffix = model.ObserveProperty(m => m.Suffix).ToReactiveProperty();

            // ViewModel -> Model
            Prefix.Subscribe(x => model.Prefix = x).AddTo(Disposables);
            Number.Subscribe(x => model.Number = x).AddTo(Disposables);
            Suffix.Subscribe(x => model.Suffix = x).AddTo(Disposables);
        }

        public ReactiveProperty<string> Prefix { get; }

        public ReactiveProperty<uint?> Number { get; }

        public ReactiveProperty<string> Suffix { get; }
    }
}