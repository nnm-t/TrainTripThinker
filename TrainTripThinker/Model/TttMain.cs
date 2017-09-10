using TrainTripThinker.Core;

namespace TrainTripThinker.Model
{
    /// <summary>
    ///     Train Trip Thinkerメインクラス
    /// </summary>
    public class TttMain
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        public TttMain()
        {
            this.Main = new Main();
        }

        /// <summary>
        /// ロジッククラスのインスタンス
        /// </summary>
        public Main Main { get; }
    }
}