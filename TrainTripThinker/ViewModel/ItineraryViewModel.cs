using System;

using Prism.Mvvm;

using Reactive.Bindings;
using Reactive.Bindings.Extensions;

using TrainTripThinker.Core.Data;

namespace TrainTripThinker.ViewModel
{
    public class ItineraryViewModel : BindableBase
    {

        public ItineraryViewModel(Itinerary model)
        {
            Title = model.ObserveProperty(m => m.Title).ToReactiveProperty();
            Elements = model.Elements.ToReadOnlyReactiveCollection(
                ItineraryElementViewModelFactory.CreateViewModel);

            Title.Subscribe(x => model.Title = x);

            AddTransportElementCommand = new ReactiveCommand();
            AddTransportElementCommand.Subscribe(model.AddTransportElement);

            AddItineraryElementCommand = new ReactiveCommand();
            AddItineraryElementCommand.Subscribe(model.AddItineraryElement);

            AddPeriodElementCommand = new ReactiveCommand();
            AddPeriodElementCommand.Subscribe(model.AddPeriodElement);
        }

        public ReactiveProperty<string> Title { get; }

        public ReadOnlyReactiveCollection<ItineraryElementViewModel> Elements { get; }

        public ReactiveCommand AddTransportElementCommand { get; }

        public ReactiveCommand AddItineraryElementCommand { get; }

        public ReactiveCommand AddPeriodElementCommand { get; }
    }
}