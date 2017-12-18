using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Prism.Mvvm;

using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    ///     行程表の要素の基本クラス
    /// </summary>
    /// <inheritdoc cref="BindableBase" />
    public class ItineraryElement : FileChangeNotifyBase
    {
        private Color32 color;

        private string freeForm;

        private ItineraryIcon icon;

        private ItineraryElementDelegates delegates;


        public ItineraryElement(ItineraryElementDelegates delegates) : this()
        {
            this.delegates = delegates;
        }

        public ItineraryElement()
        {
            Icon = ItineraryIcon.None;
            Color = Color32.Transparent;
            FreeForm = string.Empty;
        }

        /// <summary>
        ///     分類用の色
        /// </summary>
        public Color32 Color
        {
            get => color;
            set => SetProperty(ref color, value);
        }

        /// <summary>
        ///     自由入力欄
        /// </summary>
        public string FreeForm
        {
            get => freeForm;
            set => SetProperty(ref freeForm, value);
        }

        /// <summary>
        ///     アイコン
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public ItineraryIcon Icon
        {
            get => icon;
            set => SetProperty(ref icon, value);
        }

        public void AddDelegates(ItineraryElementDelegates delegates)
        {
            this.delegates = delegates;
        }

        public void RemoveElement()
        {
            delegates.Remove(this);
        }

        public void MoveUpElement()
        {
            delegates.MoveUp(this);
        }

        public void MoveDownElement()
        {
                delegates.MoveDown(this);
        }
    }
}