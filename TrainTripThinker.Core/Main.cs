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
            Document = new TttDocument();
        }

        /// <summary>
        /// 開いたファイルが変更されているか?
        /// </summary>
        public static bool IsFileChanged { get; set; }

        /// <summary>
        /// オープン中の行程表ドキュメント
        /// </summary>
        public TttDocument Document { get; set; }

        /// <summary>
        /// ファイル新規作成
        /// </summary>
        public bool CreateDocument()
        {
            if (IsFileChanged)
            {
                // ファイル変更されている
            }

            Document = new TttDocument();

            return true;
        }
    }
}
