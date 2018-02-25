using System;
using System.Reactive.Disposables;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Core.Data;
using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.ViewModel
{
    public class TransportSeatViewModel : ViewModelBase
    {
        public TransportSeatViewModel(TransportSeat model)
        {
            Type = model.ObserveProperty(m => m.Type).ToReactiveProperty();
            Remarks = model.ObserveProperty(m => m.Remarks).ToReactiveProperty();

            // ViewModel -> Model
            Type.Subscribe(x => model.Type = x).AddTo(Disposables);
            Remarks.Subscribe(x => model.Remarks = x).AddTo(Disposables);
        }

        public ReactiveProperty<SeatType> Type { get; }

        public ReactiveProperty<string> Remarks { get; }
    }
}