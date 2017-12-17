using System;
using System.ComponentModel;
using System.Windows;

using Reactive.Bindings;

namespace TrainTripThinker.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        private bool isShowFileChangeDialog;

        private Action fileChangeDialogAction;

        public MainWindowViewModel()
        {
            CloseDialogCommand = new ReactiveCommand<bool?>();
            CloseDialogCommand.Subscribe(OnCloseFileChangeDialog);

            CreateDocummentCommand = new ReactiveCommand();
            CreateDocummentCommand.Subscribe(() => JudgeShowFileChangeDialog(() => Main.CreateDocument()));

            OpenFileCommand = new ReactiveCommand();
            OpenFileCommand.Subscribe(() => JudgeShowFileChangeDialog(() => Main.OpenFile()));

            SaveFileCommand = new ReactiveCommand();
            SaveFileCommand.Subscribe(() => Main.SaveFile());

            ClosingWindowCommand = new ReactiveCommand<CancelEventArgs>();
            ClosingWindowCommand.Subscribe(OnClosingWindow);
        }

        public bool IsShowFileChangeDialog
        {
            get => isShowFileChangeDialog;
            set => SetProperty(ref isShowFileChangeDialog, value);
        }

        public ReactiveCommand CreateDocummentCommand { get; }

        public ReactiveCommand OpenFileCommand { get; }

        public ReactiveCommand SaveFileCommand { get; }

        public ReactiveCommand<bool?> CloseDialogCommand { get; }

        public ReactiveCommand<CancelEventArgs> ClosingWindowCommand { get; }

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
                Main.SaveFile();
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
    }
}