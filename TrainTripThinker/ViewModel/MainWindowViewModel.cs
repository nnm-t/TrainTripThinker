using Prism.Mvvm;

using Reactive.Bindings;

namespace TrainTripThinker.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
        }

        public ReactiveCommand CreateDocummentCommand { get; }

        public ReactiveCommand OpenFileCommand { get; }

        public ReactiveCommand SaveFileCommand { get; }
    }
}