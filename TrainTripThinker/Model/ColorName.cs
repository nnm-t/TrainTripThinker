using TrainTripThinker.Core.Data;

namespace TrainTripThinker.Model
{
    /// <summary>
    /// 色・名前の要素を取りまとめる
    /// </summary>
    public class ColorName
    {
        /// <summary>
        /// 色
        /// </summary>
        public Color32 Color { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }
    }
}