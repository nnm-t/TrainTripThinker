using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Core.Utility;
using TrainTripThinker.Model;

namespace TrainTripThinker.ViewModel
{
    public class AboutViewModel : ViewModelBase
    {
        private readonly About about;

        private bool isShowDialog;

        public AboutViewModel()
        {
            about = Main.About;

            LicenseText = about.ObserveProperty(a => a.LicenseText).ToReactiveProperty();

            ShowWikiCommand = new ReactiveCommand();
            ShowWikiCommand.Subscribe(TttHelp.AccessToWiki);

            ShowWebSiteCommand = new ReactiveCommand();
            ShowWebSiteCommand.Subscribe(TttHelp.AccessToWebSite);

            ShowGitHubCommand = new ReactiveCommand();
            ShowGitHubCommand.Subscribe(TttHelp.AccessToGitHub);

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

        public ReactiveProperty<string> LicenseText { get; }

        public ReactiveCommand ShowWikiCommand { get; }

        public ReactiveCommand ShowAboutCommand { get; }

        public ReactiveCommand CloseAboutCommand { get; }

        public ReactiveCommand ShowGitHubCommand { get; }

        public ReactiveCommand ShowWebSiteCommand { get; }

        public string AssemblyVersion => AssemblyInformation.GetAssemblyVersion().ToString();

        public string AssemblyTitle => AssemblyInformation.GetAssemblyTitle();

        public string AssemblyCopyright => AssemblyInformation.GetAssemblyCopyright();
    }
}