using Reactive.Bindings;
using TrainTripThinker.Model;

namespace TrainTripThinker.ViewModel
{
    public class MainRightWindowViewModel : ViewModelBase
    {
        public MainRightWindowViewModel()
        {
            ShowWikiCommand = new ReactiveCommand();
            ShowWikiCommand.Subscribe(TttHelp.AccessToWiki);
        }

        public ReactiveCommand ShowWikiCommand { get; }

        public ReactiveCommand ShowAboutCommand { get; }
    }
}