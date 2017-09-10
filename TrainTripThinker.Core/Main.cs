using TrainTripThinker.Core.Data;

namespace TrainTripThinker.Core
{
    /// <summary>
    /// ロジックメインクラス
    /// </summary>
    public class Main
    {
        /// <summary>
        /// 起動時コンストラクタ
        /// </summary>
        public Main()
        {
            this.Document = new TttDocument();
        }

        /// <summary>
        /// オープン中の行程表ドキュメント
        /// </summary>
        public TttDocument Document { get; set; }
    }
}
