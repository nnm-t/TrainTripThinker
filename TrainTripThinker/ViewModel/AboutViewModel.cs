using Reactive.Bindings;
using TrainTripThinker.Core.Utility;
using TrainTripThinker.Model;

namespace TrainTripThinker.ViewModel
{
    public class AboutViewModel : ViewModelBase
    {
        private bool isShowDialog;

        public AboutViewModel()
        {
            ShowWikiCommand = new ReactiveCommand();
            ShowWikiCommand.Subscribe(TttHelp.AccessToWiki);

            ShowAboutCommand = new ReactiveCommand();
            ShowAboutCommand.Subscribe(() => IsShowDialog = true);

            CloseAboutCommand = new ReactiveCommand();
            CloseAboutCommand.Subscribe(() => IsShowDialog = false);
        }

        public bool IsShowDialog
        {
            get => isShowDialog;
            set => SetProperty(ref isShowDialog, value);
        }

        public ReactiveCommand ShowWikiCommand { get; }

        public ReactiveCommand ShowAboutCommand { get; }

        public ReactiveCommand CloseAboutCommand { get; }

        public string AssemblyVersion => AssemblyInformation.GetAssemblyVersion().ToString();

        public string AssemblyTitle => AssemblyInformation.GetAssemblyTitle();

        public string AssemblyCopyright => AssemblyInformation.GetAssemblyCopyright();
    }
}