using Prism.Mvvm;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 乗り物の種別
    /// </summary>
    public class TransportClass : BindableBase
    {
        private string text;

        public TransportClass(string text)
        {
            Text = text;
        }

        /// <summary>
        /// 普通
        /// </summary>
        public static TransportClass Local => new TransportClass("普通");

        /// <summary>
        /// 快速
        /// </summary>
        public static TransportClass Rapid => new TransportClass("快速");

        /// <summary>
        /// 急行
        /// </summary>
        public static TransportClass Express => new TransportClass("急行");

        /// <summary>
        /// 特急
        /// </summary>
        public static TransportClass LimitedExpress => new TransportClass("特急");

        /// <summary>
        /// 種別の文字列
        /// </summary>
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

    }
}