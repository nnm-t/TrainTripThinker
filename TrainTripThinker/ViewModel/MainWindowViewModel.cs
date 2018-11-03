using System;
using System.ComponentModel;
using System.Reactive.Linq;
using System.Reflection;
using System.Windows;
using System.Windows.Media;
using System.Windows.Media.Imaging;

using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace TrainTripThinker.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool isShowFileChangeDialog;

        private bool isShowSettings;

        private Action fileChangeDialogAction;

        public MainWindowViewModel()
        {
            Assembly assembly = Assembly.GetExecutingAssembly();
            var productName = Attribute.GetCustomAttribute(assembly, typeof(AssemblyProductAttribute)) as AssemblyProductAttribute;

            DocumentName = Main.ObserveProperty(m => m.DocumentName).ToReactiveProperty();
            WindowTitle = Main.ObserveProperty(m => m.DocumentName).Select(n => n + " - " + productName.Product).ToReactiveProperty();

            CloseDialogCommand = new ReactiveCommand<bool?>();
            CloseDialogCommand.Subscribe(OnCloseFileChangeDialog);

            CreateDocummentCommand = new ReactiveCommand();
            CreateDocummentCommand.Subscribe(() => JudgeShowFileChangeDialog(() => Main.CreateDocument()));

            OpenFileCommand = new ReactiveCommand();
            OpenFileCommand.Subscribe(() => JudgeShowFileChangeDialog(() => Main.OpenDocument()));

            SaveFileCommand = new ReactiveCommand();
            SaveFileCommand.Subscribe(() => Main.SaveDocument());

            PrintCommand = new ReactiveCommand();
            PrintCommand.Subscribe(() => Main.Print());

            ClosingWindowCommand = new ReactiveCommand<CancelEventArgs>();
            ClosingWindowCommand.Subscribe(OnClosingWindow);

            CaptureScreenshotCommand = new ReactiveCommand<Visual>();
            CaptureScreenshotCommand.Subscribe(CaptureScreenShot);
        }

        public bool IsShowFileChangeDialog
        {
            get => isShowFileChangeDialog;
            set => SetProperty(ref isShowFileChangeDialog, value);
        }

        public bool IsShowSettings
        {
            get => isShowSettings;
            set => SetProperty(ref isShowSettings, value);
        }

        public ReactiveProperty<string> DocumentName { get; }

        public ReactiveProperty<string> WindowTitle { get; }

        public ReactiveCommand CreateDocummentCommand { get; }

        public ReactiveCommand OpenFileCommand { get; }

        public ReactiveCommand SaveFileCommand { get; }

        public ReactiveCommand PrintCommand { get; }

        public ReactiveCommand<bool?> CloseDialogCommand { get; }

        public ReactiveCommand<CancelEventArgs> ClosingWindowCommand { get; }

        public ReactiveCommand<Visual> CaptureScreenshotCommand { get; }

        public void JudgeShowFileChangeDialog(Action action)
        {
            if (!Main.JudgeIsFileChanged(action))
            {
                return;
            }

            fileChangeDialogAction = action;
            IsShowFileChangeDialog = true;
        }

        public void OnCloseFileChangeDialog(bool? dialogResult)
        {
            IsShowFileChangeDialog = false;

            if (dialogResult == null)
            {
                // キャンセル
                return;
            }

            if (dialogResult.Value)
            {
                // はい
                // 保存のロジックを割り込ませる
                Main.SaveDocument();
            }

            // いいえ
            fileChangeDialogAction();
        }

        public void OnClosingWindow(CancelEventArgs e)
        {
            // 一旦終了を抑止
            e.Cancel = true;

            // ダイアログの結果に応じてAppication.Current.Shutdown()で落とす
            JudgeShowFileChangeDialog(() => Application.Current.Shutdown());
        }

        public void CaptureScreenShot(Visual visual)
        {
            // スクリーンショット撮影
            Rect bounds = VisualTreeHelper.GetDescendantBounds(visual);

            // TODO: 設定でこのへんいじれるようにしてもいいかも
            var bitmap = new RenderTargetBitmap((int)bounds.Width, (int)bounds.Height, 96, 96, PixelFormats.Pbgra32);
            var dv = new DrawingVisual();

            using (DrawingContext dc = dv.RenderOpen())
            {
                var vb = new VisualBrush(visual);
                dc.DrawRectangle(vb, null, bounds);
            }

            bitmap.Render(dv);
            bitmap.Freeze();

            // ファイル保存呼び出し
            Main.SaveScreenShot(bitmap);
        }
    }
}