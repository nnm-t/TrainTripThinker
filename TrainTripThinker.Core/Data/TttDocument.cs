using System.Collections.ObjectModel;

using Prism.Mvvm;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// Train Trip Thinkerのドキュメントクラス
    /// </summary>
    public class TttDocument : BindableBase
    {
        private ObservableCollection<Itinerary> itineraries;

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
        public ObservableCollection<Itinerary> Itineraries
        {
            get => this.itineraries;
            set => this.SetProperty(ref this.itineraries, value);
        }
    }
}