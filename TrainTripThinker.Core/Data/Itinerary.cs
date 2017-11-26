using System;
using System.Collections.ObjectModel;

using Prism.Mvvm;

namespace TrainTripThinker.Core.Data
{
    /// <inheritdoc />
    /// <summary>
    /// 行程表
    /// </summary>
    public class Itinerary : BindableBase
    {
        private string title;

        private ItineraryElementDelegates delegates;

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

            delegates = new ItineraryElementDelegates(RemoveElement, MoveUpElement, MoveDownElement);
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
            Elements.Add(new TransportElement(new Train(), delegates));
        }

        public void RemoveElement(ItineraryElement element)
        {
            Elements.Remove(element);
        }

        public bool MoveUpElement(ItineraryElement element)
        {
            int index = Elements.IndexOf(element);

            if (index == 0)
            {
                return false;
            }

            Elements.Remove(element);

            Elements.Insert(index - 1, element);

            return true;
        }

        public bool MoveDownElement(ItineraryElement element)
        {
            int index = Elements.IndexOf(element);

            if (index == Elements.Count - 1)
            {
                return false;
            }

            Elements.Remove(element);

            Elements.Insert(index + 1, element);

            return true;
        }
    }
}