using System;
using System.Collections.ObjectModel;

using Prism.Mvvm;

using Reactive.Bindings;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Model;

namespace TrainTripThinker.ViewModel
{

    /// <inheritdoc />
    /// <summary>
    /// <see cref="T:TrainTripThinker.View.ItineraryViewer" />用ViewModel
    /// </summary>
    public class ItineraryViewerViewModel : BindableBase
    {
        /// <summary>
        /// Mainインスタンスへの参照
        /// </summary>
        private readonly TttMain main = ModelManager<TttMain>.Instance;

        /// <summary>
        /// ドキュメントインスタンスへの参照
        /// </summary>
        private readonly TttDocument document;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ItineraryViewerViewModel()
        {
            document = main.Document;

            Itineraries = document.Itineraries.ToReadOnlyReactiveCollection(x => new ItineraryViewModel(x));

            AddItineraryCommand = new ReactiveCommand();
            AddItineraryCommand.Subscribe(_ => document.AddItinerary());
            RemoveItineraryCommand = new ReactiveCommand<int>();
            RemoveItineraryCommand.Subscribe(index => document.RemoveItinerary(index));
        }

        /// <summary>
        /// 行程表インスタンス
        /// </summary>
        public ReadOnlyObservableCollection<ItineraryViewModel> Itineraries { get; }

        /// <summary>
        /// 行程表を追加
        /// </summary>
        public ReactiveCommand AddItineraryCommand { get; }

        /// <summary>
        /// 行程表を削除
        /// </summary>
        public ReactiveCommand<int> RemoveItineraryCommand { get; } 

    }
}