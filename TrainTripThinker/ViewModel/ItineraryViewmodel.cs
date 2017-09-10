using System.Collections.ObjectModel;

using Prism.Mvvm;

using Reactive.Bindings;
using Reactive.Bindings.Extensions;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Model;

namespace TrainTripThinker.ViewModel
{
    /// <summary>
    /// <see cref="View.ItineraryViewer"/>用ViewModel
    /// </summary>
    public class ItineraryViewModel : BindableBase
    {
        /// <summary>
        /// Mainインスタンスへの参照
        /// </summary>
        private readonly TttMain main = ModelManager<TttMain>.Instance;

        /// <summary>
        /// ドキュメントインスタンスへの参照
        /// </summary>
        private TttDocument document;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ItineraryViewModel()
        {
            this.document = this.main.Document;

            this.Itineraries = this.document.ObserveProperty(d => d.Itineraries).ToReactiveProperty();
        }

        /// <summary>
        /// 行程表インスタンス
        /// </summary>
        public ReactiveProperty<ObservableCollection<Itinerary>> Itineraries { get; }

    }
}