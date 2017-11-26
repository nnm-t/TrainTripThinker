using Prism.Mvvm;

using Reactive.Bindings;
using Reactive.Bindings.Extensions;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.ViewModel
{
    public abstract class ItineraryElementViewModel : BindableBase
    {
        protected ItineraryElementViewModel(ItineraryElement model)
        {
            Color = model.ObserveProperty(m => m.Color).ToReactiveProperty();
            FreeForm = model.ObserveProperty(m => m.FreeForm).ToReactiveProperty();
            Icon = model.ObserveProperty(m => m.Icon).ToReactiveProperty();

            RemoveElementCommand = new ReactiveCommand();
            RemoveElementCommand.Subscribe(model.RemoveElement);
        }

        public ReactiveProperty<Color32> Color { get; }

        public ReactiveProperty<string> FreeForm { get; }

        public ReactiveProperty<ItineraryIcon> Icon { get; }

        public ReactiveCommand RemoveElementCommand { get; }
    }
}