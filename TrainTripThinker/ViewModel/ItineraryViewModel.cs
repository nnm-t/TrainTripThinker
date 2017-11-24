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
            Elements = model.Elements.ToReadOnlyReactiveCollection();

            AddTransportElementCommand = new ReactiveCommand();
            AddTransportElementCommand.Subscribe(model.AddTransportElement);
        }

        public ReactiveProperty<string> Title { get; }

        public ReadOnlyReactiveCollection<ItineraryElement> Elements { get; }

        public ReactiveCommand AddTransportElementCommand { get; }
    }
}