using System.Collections.ObjectModel;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    ///     行程表
    /// </summary>
    public class Itinerary
    {
        /// <summary>
        ///     コンストラクタ
        /// </summary>
        public Itinerary()
        {
            this.Elements = new ObservableCollection<ItineraryElement>();
        }

        /// <summary>
        ///     行程表のアイテムのコレクション
        /// </summary>
        public ObservableCollection<ItineraryElement> Elements { get; set; }
    }
}