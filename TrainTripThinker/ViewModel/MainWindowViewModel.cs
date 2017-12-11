using Prism.Mvvm;

using Reactive.Bindings;
using Reactive.Bindings.Extensions;

namespace TrainTripThinker.ViewModel
{
    public class MainWindowViewModel : ViewModelBase
    {
        public MainWindowViewModel()
        {
            IsShowFileChangeDialog = Main.ObserveProperty(m => m.IsShowFileChangeDialog).ToReactiveProperty();

            CreateDocummentCommand = new ReactiveCommand();
            OpenFileCommand = new ReactiveCommand();
            SaveFileCommand = new ReactiveCommand();
        }

        public ReactiveProperty<bool> IsShowFileChangeDialog { get; }

        public ReactiveCommand CreateDocummentCommand { get; }

        public ReactiveCommand OpenFileCommand { get; }

        public ReactiveCommand SaveFileCommand { get; }
    }
}