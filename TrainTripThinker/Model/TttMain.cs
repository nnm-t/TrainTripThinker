using Newtonsoft.Json;

using Prism.Mvvm;

using TrainTripThinker.Core;
using TrainTripThinker.Core.Data;

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

        private bool isShowFileChangeDialog;

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        public TttMain()
        {
            main = new Main();

            var textReader = new TextReader(settingsJson);
            Settings = JsonConvert.DeserializeObject<TttSettings>(textReader.Read());

            ThemeSelector = new ThemeSelector(Settings);
        }

        /// <summary>
        ///     ドキュメントインスタンス
        /// </summary>
        public TttDocument Document => main.Document;

        public TttSettings Settings { get; }

        public ThemeSelector ThemeSelector { get; }

        public bool IsShowFileChangeDialog
        {
            get => isShowFileChangeDialog;
            set => SetProperty(ref isShowFileChangeDialog, value);
        }

        /// <summary>
        /// ファイル新規作成
        /// </summary>
        public bool CreateDocument()
        {
            if (Main.IsFileChanged)
            {
                // ファイル変更されている
                IsShowFileChangeDialog = true;
            }

            return main.CreateDocument();
        }
    }
}