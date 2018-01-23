using System.Reactive.Linq;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Core.Data;

namespace TrainTripThinker.ViewModel
{
    public abstract class TransportBaseViewModel
    {
        protected TransportBaseViewModel(TransportBase model)
        {
            TransportNumber = model.ObserveProperty(m => m.TransportNumber).Select(n => new TransportNumberViewModel(n))
                .ToReactiveProperty();
            Name = model.ObserveProperty(m => m.Name).ToReactiveProperty();
            Destination = model.ObserveProperty(m => m.Destination).ToReactiveProperty();

            Routes = model.Routes.ToReadOnlyReactiveCollection();
        }

        public ReactiveProperty<TransportNumberViewModel> TransportNumber { get; }

        public ReadOnlyReactiveCollection<string> Routes { get; }

        public ReactiveProperty<string> Name { get; }

        public ReactiveProperty<string> Destination { get; }
    }
}