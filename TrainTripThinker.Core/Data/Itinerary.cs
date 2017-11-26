﻿using System.Collections.ObjectModel;

using Prism.Mvvm;

using TrainTripThinker.Core.Utility;

namespace TrainTripThinker.Core.Data
{
    /// <inheritdoc />
    /// <summary>
    /// 行程表
    /// </summary>
    public class Itinerary : BindableBase
    {
        private string title;

        private readonly ItineraryElementDelegates delegates;

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
            Elements.Add(new TransportElement(new Train(), delegates));
        }
    }
}