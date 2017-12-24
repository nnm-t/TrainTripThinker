using System;
using System.Collections.ObjectModel;
using System.Linq;
using Newtonsoft.Json;

using Prism.Mvvm;

using Reactive.Bindings.Extensions;

using TrainTripThinker.Core.Utility;

namespace TrainTripThinker.Core.Data
{
    /// <inheritdoc />
    /// <summary>
    /// 行程表
    /// </summary>
    public class Itinerary : FileChangeNotifyBase
    {
        private readonly ItineraryElementDelegates delegates;

        private string title;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="title">
        /// タイトル名
        /// </param>
        public Itinerary(string title) : this()
        {
            Title = title;
        }

        public Itinerary()
        {
            Elements = new ObservableCollection<ItineraryElement>();
            Elements.CollectionChangedAsObservable().Subscribe(OnCollectionChanged);

            delegates = new ItineraryElementDelegates(Elements.Remove, Elements.MoveUpElement, Elements.MoveDownElement);
        }

        /// <summary>
        /// 行程表のタイトル
        /// </summary>
        public string Title
        {
            get => title;
            set => SetProperty(ref title, value);
        }

        /// <summary>
        /// 行程表のアイテムのコレクション
        /// </summary>
        public ObservableCollection<ItineraryElement> Elements { get; set; }

        public void AddTransportElement()
        {
            DateTime? endTime = GetLastPeriodElementEndTime();
            if (!endTime.HasValue)
            {
                Elements.Add(new TransportElement(new Train(), delegates));
                return;
            }
            Elements.Add(new TransportElement(new Train(), delegates, endTime.Value));
        }

        public void AddItineraryElement()
        {
            Elements.Add(new ItineraryElement(delegates));
        }

        public void AddPeriodElement()
        {
            DateTime? endTime = GetLastPeriodElementEndTime();

            if (!endTime.HasValue)
            {
                Elements.Add(new PeriodElement(delegates));
                return;
            }
            Elements.Add(new PeriodElement(delegates, endTime.Value));
        }

        public void AddDelegateToElements()
        {
            foreach (ItineraryElement element in Elements)
            {
                element.AddDelegates(delegates);
            }
        }

        private DateTime? GetLastPeriodElementEndTime()
        {
            return (Elements.LastOrDefault(e => e is PeriodElement) as PeriodElement)?.Period.End.DateTime;
        }
    }
}