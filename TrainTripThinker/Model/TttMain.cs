using TrainTripThinker.Core;
using TrainTripThinker.Core.Data;

namespace TrainTripThinker.Model
{
    /// <summary>
    ///     Train Trip Thinkerメインクラス
    /// </summary>
    public class TttMain
    {
        /// <summary>
        ///     ロジッククラスのインスタンス
        /// </summary>
        private readonly Main main;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        public TttMain()
        {
            this.main = new Main();
        }

        /// <summary>
        ///     ドキュメントインスタンス
        /// </summary>
        public TttDocument Document => this.main.Document;
    }
}