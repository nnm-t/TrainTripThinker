using Reactive.Bindings;
using Reactive.Bindings.Extensions;

using TrainTripThinker.Core.Data;

namespace TrainTripThinker.ViewModel
{
    public class TransportElementViewModel : PeriodElementViewModel
    {
        public TransportElementViewModel(TransportElement model)
            : base(model)
        {
            Transport = model.ObserveProperty(m => m.Transport).ToReactiveProperty();
        }

        public ReactiveProperty<TransportBase> Transport { get; }
    }
}