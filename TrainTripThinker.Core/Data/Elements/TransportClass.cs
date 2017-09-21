using Prism.Mvvm;

using TrainTripThinker.Core.Structs;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 乗り物の種別
    /// </summary>
    public class TransportClass : BindableBase
    {
        private string text;
        private Color32 background;
        private Color32 foreground;

        /// <inheritdoc />
        /// <summary>
        /// 種別インスタンス生成(白地黒文字)
        /// </summary>
        /// <param name="text">種別文字</param>
        public TransportClass(string text) : this(text, Color32.White, Color32.Black)
        {
            
        }

        /// <summary>
        /// 種別インスタンス生成(背景・文字色指定)
        /// </summary>
        /// <param name="text">種別文字</param>
        /// <param name="background">背景色</param>
        /// <param name="foreground">文字色</param>
        public TransportClass(string text, Color32 background, Color32 foreground)
        {
            Text = text;
            Background = background;
            Foreground = foreground;
        }

        /// <summary>
        /// 普通
        /// </summary>
        public static TransportClass Local => new TransportClass("普通");

        /// <summary>
        /// 普通(黒地白文字)
        /// </summary>
        public static TransportClass LocalBlack => new TransportClass("普通", Color32.Black, Color32.White);

        /// <summary>
        /// 快速
        /// </summary>
        public static TransportClass Rapid => new TransportClass("快速");

        /// <summary>
        /// 急行(赤字白文字)
        /// </summary>
        public static TransportClass Express => new TransportClass("急行", Color32.Red, Color32.White);

        /// <summary>
        /// 特急(赤字白文字)
        /// </summary>
        public static TransportClass LimitedExpress => new TransportClass("特急", Color32.Red, Color32.White);

        /// <summary>
        /// 種別の文字列
        /// </summary>
        public string Text
        {
            get => text;
            set => SetProperty(ref text, value);
        }

        /// <summary>
        /// 種別色(背景)
        /// </summary>
        public Color32 Background
        {
            get => background;
            set => SetProperty(ref background, value);
        }

        /// <summary>
        /// 種別色(前景)
        /// </summary>
        public Color32 Foreground
        {
            get => foreground;
            set => SetProperty(ref foreground, value);
        }
    }
}