using System;
using System.Collections.ObjectModel;

using Reactive.Bindings;

using TrainTripThinker.Core.Data;

namespace TrainTripThinker.ViewModel
{

    /// <inheritdoc />
    /// <summary>
    /// <see cref="T:TrainTripThinker.View.ItineraryViewer" />用ViewModel
    /// </summary>
    public class ItineraryViewerViewModel : ViewModelBase
    {
        /// <summary>
        /// ドキュメントインスタンスへの参照
        /// </summary>
        private readonly TttDocument document;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public ItineraryViewerViewModel()
        {
            document = Main.Document;

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