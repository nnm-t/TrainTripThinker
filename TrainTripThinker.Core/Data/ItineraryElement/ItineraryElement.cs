using Prism.Mvvm;

using TrainTripThinker.Core.Enums;
using TrainTripThinker.Core.Structs;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    ///     行程表の要素の基本クラス
    /// </summary>
    /// <inheritdoc cref="BindableBase" />
    public abstract class ItineraryElement : BindableBase
    {
        private Color32 color;

        private string freeForm;

        private ItineraryIcon icon;

        protected ItineraryElement()
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
        public ItineraryIcon Icon
        {
            get => icon;
            set => SetProperty(ref icon, value);
        }
    }
}