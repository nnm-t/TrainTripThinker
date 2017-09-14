using System.Collections.ObjectModel;

using Prism.Mvvm;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// Train Trip Thinkerのドキュメントクラス
    /// </summary>
    /// <inheritdoc cref="BindableBase"/>
    public class TttDocument : BindableBase
    {
        /// <summary>
        /// 行程表コレクション
        /// </summary>
        private ObservableCollection<Itinerary> itineraries;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TttDocument()
        {
            Itineraries = new ObservableCollection<Itinerary>();
        }

        /// <summary>
        /// 行程表の数
        /// </summary>
        public int ItineraryCount => itineraries.Count;

        /// <summary>
        /// 行程表コレクション
        /// </summary>
        public ObservableCollection<Itinerary> Itineraries
        {
            get => itineraries;
            set => SetProperty(ref itineraries, value);
        }

        /// <summary>
        /// 行程表を追加
        /// </summary>
        public void AddItinerary()
        {
            itineraries.Add(new Itinerary("Itinerary" + ItineraryCount));
        }

        /// <summary>
        /// <see cref="index"/>番目の行程表を削除
        /// </summary>
        /// <param name="index">行程表のインデックス</param>
        public void RemoveItinerary(int index)
        {
            itineraries.RemoveAt(index);
        }
    }
}