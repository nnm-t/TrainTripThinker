using System.Windows.Media;
using TrainTripThinker.Core.Data;

namespace TrainTripThinker.Extensions
{
    /// <summary>
    /// <see cref="Color32"/>型の拡張メソッド群
    /// </summary>
    public static class Color32Extensions
    {
        /// <summary>
        /// <see cref="Color"/>型に変換
        /// </summary>
        /// <param name="color32"><see cref="Color32"/>型インスタンス</param>
        /// <returns><see cref="Color"/>型インスタンス</returns>
        public static Color ToColor(this Color32 color32)
        {
            return Color.FromArgb(color32.A, color32.R, color32.G, color32.B);
        }

        /// <summary>
        /// ベタ塗りの<see cref="SolidColorBrush"/>型に変換
        /// </summary>
        /// <param name="color32"><see cref="Color32"/>型インスタンス</param>
        /// <returns><see cref="SolidColorBrush"/>型インスタンス</returns>
        public static SolidColorBrush ToSolidColorBrush(this Color32 color32)
        {
            return new SolidColorBrush(color32.ToColor());
        }
    }
}