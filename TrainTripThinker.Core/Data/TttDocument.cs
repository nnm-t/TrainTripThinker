using System.Collections.ObjectModel;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// Train Trip Thinkerのドキュメントクラス
    /// </summary>
    public class TttDocument
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TttDocument()
        {
            this.Itineraries = new ObservableCollection<Itinerary>();
        }

        /// <summary>
        /// 行程表のコレクション
        /// </summary>
        public ObservableCollection<Itinerary> Itineraries { get; set; }
    }
}