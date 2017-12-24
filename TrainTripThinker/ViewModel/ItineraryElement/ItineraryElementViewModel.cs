using System;

using Prism.Mvvm;

using Reactive.Bindings;
using Reactive.Bindings.Extensions;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.ViewModel
{
    public class ItineraryElementViewModel : BindableBase
    {
        public ItineraryElementViewModel(ItineraryElement model)
        {
            Color = model.ObserveProperty(m => m.Color).ToReactiveProperty();
            FreeForm = model.ObserveProperty(m => m.FreeForm).ToReactiveProperty();
            Icon = model.ObserveProperty(m => m.Icon).ToReactiveProperty();

            FreeForm.Subscribe(x => model.FreeForm = x);
            Color.Subscribe(x => model.Color = x);
            Icon.Subscribe(x => model.Icon = x);

            RemoveElementCommand = new ReactiveCommand();
            RemoveElementCommand.Subscribe(model.RemoveElement);

            MoveUpElementCommand = new ReactiveCommand();
            MoveUpElementCommand.Subscribe(model.MoveUpElement);

            MoveDownElementCommand = new ReactiveCommand();
            MoveDownElementCommand.Subscribe(model.MoveDownElement);
        }

        public ReactiveProperty<Color32> Color { get; }

        public ReactiveProperty<string> FreeForm { get; }

        public ReactiveProperty<ItineraryIcon> Icon { get; }

        public ReactiveCommand RemoveElementCommand { get; }

        public ReactiveCommand MoveUpElementCommand { get; }

        public ReactiveCommand MoveDownElementCommand { get; }
    }
}