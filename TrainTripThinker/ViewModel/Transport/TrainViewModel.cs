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
            Seat = model.ObserveProperty(m => m.Seat).ToReactiveProperty();
            HasRestRoom = model.ObserveProperty(m => m.HasRestRoom).ToReactiveProperty();
            MealType = model.ObserveProperty(m => m.MealType).ToReactiveProperty();
        }

        public ReactiveProperty<TransportClass> Class { get; }

        public ReactiveProperty<Color32> LineColor { get; }

        public ReactiveProperty<TransportSeat> Seat { get; }

        public ReactiveProperty<bool> HasRestRoom { get; }

        public ReactiveProperty<MealType> MealType { get; }
    }
}