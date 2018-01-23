using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Core.Data;

namespace TrainTripThinker.ViewModel
{
    public class PlatformViewModel : ViewModelBase
    {
        public PlatformViewModel(Platform model)
        {
            Prefix = model.ObserveProperty(m => m.Prefix).ToReactiveProperty();
            Number = model.ObserveProperty(m => m.Number).ToReactiveProperty();
            Suffix = model.ObserveProperty(m => m.Suffix).ToReactiveProperty();
        }

        public ReactiveProperty<string> Prefix { get; }
        public ReactiveProperty<string> Number { get; }
        public ReactiveProperty<string> Suffix { get; }
    }
}