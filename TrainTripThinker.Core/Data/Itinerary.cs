using System.Collections.ObjectModel;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    ///     行程表
    /// </summary>
    public class Itinerary
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">
        /// タイトル名
        /// </param>
        public Itinerary(string title)
        {
            Elements = new ObservableCollection<ItineraryElement>();
            Title = title;
        }

        /// <summary>
        /// 行程表のタイトル
        /// </summary>
        public string Title { get; set; }

        /// <summary>
        ///     行程表のアイテムのコレクション
        /// </summary>
        public ObservableCollection<ItineraryElement> Elements { get; set; }

        public void AddTransportElement()
        {
            Elements.Add(new TransportElement(new Train()));
        }
    }
}