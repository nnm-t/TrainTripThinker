using TrainTripThinker.Core.Structs;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// ラインカラーを実装するインターフェイス
    /// </summary>
    public interface ILineColor
    {
        /// <summary>
        /// ラインカラー
        /// </summary>
        Color32 LineColor { get; }
    }
}