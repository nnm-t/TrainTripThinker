using System.IO;

using Newtonsoft.Json;

using Prism.Mvvm;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Core.Utility;

namespace TrainTripThinker.Core
{
    /// <summary>
    /// ロジックメインクラス
    /// </summary>
    public class Main : BindableBase
    {
        private TttDocument document;

        /// <summary>
        /// 起動時コンストラクタ
        /// </summary>
        public Main()
        {
            Document = new TttDocument();

            IsFileChanged = false;
        }

        /// <summary>
        /// 開いたファイルが変更されているか?
        /// </summary>
        public static bool IsFileChanged { get; set; }


        /// <summary>
        /// オープン中の行程表ドキュメント
        /// </summary>
        public TttDocument Document
        {
            get => document;
            set => SetProperty(ref document, value);
        }

        /// <summary>
        /// ドキュメントを新規作成(実態は中身のリセット)
        /// </summary>
        /// <returns>成功可否</returns>
        public bool CreateDocument()
        {
            Document.Clear();
            IsFileChanged = false;

            return true;
        }

        public bool OpenDocument(string filePath)
        {
            using (var reader = new TextReader(filePath))
            {
                Document.Load(
                    JsonConvert.DeserializeObject<TttDocument>(reader.Read()));
            }

            IsFileChanged = false;

            return true;
        }

        public bool SaveDocument(string filePath)
        {
            using (var writer = new TextWriter(filePath))
            {
                writer.Write(
                    JsonConvert.SerializeObject(
                        Document,
                        Formatting.Indented));
            }

            IsFileChanged = false;

            return true;
        }
    }
}
