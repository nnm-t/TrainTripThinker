using System;
using System.Reactive.Linq;
using System.Windows;

using Newtonsoft.Json;

using Prism.Mvvm;

using Reactive.Bindings.Extensions;

using TrainTripThinker.Core;
using TrainTripThinker.Core.Data;
using TrainTripThinker.ViewModel;

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

        /// <summary>
        ///     コンストラクタ
        /// </summary>
        public TttMain()
        {
            main = new Main();

            using (var textReader = new TextReader(settingsJson))
            {
                Settings = JsonConvert.DeserializeObject<TttSettings>(textReader.Read());
            }

            ThemeSelector = new ThemeSelector(Settings);
        }

        /// <summary>
        ///     ドキュメントインスタンス
        /// </summary>
        public TttDocument Document => main.Document;

        public TttSettings Settings { get; }

        public ThemeSelector ThemeSelector { get; }

        /// <summary>
        /// ファイル新規作成
        /// </summary>
        public bool CreateDocument()
        {
            return main.CreateDocument();
        }

        public void OpenFile()
        {
            string filePath = CommonDialog.ChooseOpenFile();

            if (filePath == null)
            {
                // キャンセル
                return;
            }

            main.OpenDocument(filePath);
        }

        public void SaveFile()
        {
            string filePath = CommonDialog.ChooseSaveFile();

            if (filePath == null)
            {
                // キャンセル
                return;
            }

            main.SaveDocument(filePath);
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
    }
}