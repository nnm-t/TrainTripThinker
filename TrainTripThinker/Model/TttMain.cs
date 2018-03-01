using System;
using System.IO;
using System.Windows.Media.Imaging;

using Newtonsoft.Json;

using Prism.Mvvm;

using TrainTripThinker.Core;
using TrainTripThinker.Core.Data;
using TrainTripThinker.Model.Printing;

using TextReader = TrainTripThinker.Core.TextReader;

namespace TrainTripThinker.Model
{
    /// <summary>
    ///     Train Trip Thinkerメインクラス
    /// </summary>
    public class TttMain : BindableBase
    {
        /// <summary>
        ///     ロジッククラスのインスタンス
        /// </summary>
        private readonly Main main;

        private readonly string settingsJson = Properties.Settings.Default.SettingsJson;

        private string documentName;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        public TttMain()
        {
            main = new Main();

            DocumentName = Properties.Settings.Default.DefaultDocumentName;

            using (var textReader = new TextReader(settingsJson))
            {
                Settings = JsonConvert.DeserializeObject<TttSettings>(textReader.Read());
            }

            About = new About();
            ThemeSelector = new ThemeSelector(Settings);

            PrintingProvider = new PrintingProvider();
        }

        /// <summary>
        ///     ドキュメントインスタンス
        /// </summary>
        public TttDocument Document => main.Document;

        public string DocumentName
        {
            get => documentName;
            set => SetProperty(ref documentName, value);
        }

        public TttSettings Settings { get; }

        public ThemeSelector ThemeSelector { get; }

        public PrintingProvider PrintingProvider { get; }

        public About About { get; }

        /// <summary>
        /// ファイル新規作成
        /// </summary>
        public bool CreateDocument()
        {
            bool result = main.CreateDocument();
            DocumentName = Properties.Settings.Default.DefaultDocumentName;

            return result;
        }

        public void OpenDocument()
        {
            string filePath = CommonDialog.ChooseOpenFile(ExtensionFilter.TTTDocument);

            if (filePath == null)
            {
                // キャンセル
                return;
            }

            main.OpenDocument(filePath);
            DocumentName = Path.GetFileName(filePath);
        }

        public void SaveDocument()
        {
            SaveFile(ExtensionFilter.TTTDocument,
                path =>
                    {
                        main.SaveDocument(path);
                        DocumentName = Path.GetFileName(path);
                    });
        }

        public void SaveScreenShot(BitmapSource source)
        {
            SaveFile(ExtensionFilter.PNGImage,
                path =>
                    {
                        var writer = new BitmapWriter(source);
                        writer.Save(path);
                    });
        }

        public void Print()
        {
            // プリンタ選択ダイアログ表示
        }

        public bool JudgeIsFileChanged(Action action)
        {
            if (Main.IsFileChanged)
            {
                return true;
            }

            action();
            return false;
        }

        private void SaveFile(ExtensionFilter filter, Action<string> saveAction)
        {
            string filePath = CommonDialog.ChooseSaveFile(filter);

            if (filePath == null)
            {
                // キャンセル
                return;
            }

            saveAction(filePath);
        }
    }
}