using Prism.Mvvm;

using Reactive.Bindings;

namespace TrainTripThinker.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            CreateDocummentCommand = new ReactiveCommand();
            OpenFileCommand = new ReactiveCommand();
            SaveFileCommand = new ReactiveCommand();
        }

        public ReactiveCommand CreateDocummentCommand { get; }

        public ReactiveCommand OpenFileCommand { get; }

        public ReactiveCommand SaveFileCommand { get; }
    }
}