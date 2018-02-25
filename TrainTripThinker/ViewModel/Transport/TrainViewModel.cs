using System;
using System.Reactive.Linq;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Core.Data;
using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.ViewModel
{
    public class TrainViewModel : TransportBaseViewModel
    {
        public TrainViewModel(Train model) : base(model)
        {
            Class = model.ObserveProperty(m => m.Class).ToReactiveProperty();
            LineColor = model.ObserveProperty(m => m.LineColor).ToReactiveProperty();
            Seat = model.ObserveProperty(m => m.Seat).Select(s => new TransportSeatViewModel(s)).ToReactiveProperty();
            HasRestRoom = model.ObserveProperty(m => m.HasRestRoom).ToReactiveProperty();
            MealType = model.ObserveProperty(m => m.MealType).ToReactiveProperty();

            // ViewModel -> Model
            Class.Subscribe(x => model.Class = x).AddTo(Disposables);
            LineColor.Subscribe(x => model.LineColor = x).AddTo(Disposables);
            HasRestRoom.Subscribe(x => model.HasRestRoom = x).AddTo(Disposables);
        }

        public ReactiveProperty<TransportClass> Class { get; }

        public ReactiveProperty<Color32> LineColor { get; }

        public ReactiveProperty<TransportSeatViewModel> Seat { get; }

        public ReactiveProperty<bool> HasRestRoom { get; }

        public ReactiveProperty<MealType> MealType { get; }
    }
}