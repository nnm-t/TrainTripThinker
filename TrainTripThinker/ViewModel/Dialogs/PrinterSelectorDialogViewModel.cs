using Reactive.Bindings;

namespace TrainTripThinker.ViewModel
{
    public class PrinterSelectorDialogViewModel : ViewModelBase
    {
        public PrinterSelectorDialogViewModel()
        {
            
        }

        public ReactiveCommand PrintCommand { get; }

        public ReactiveCommand CancelCommand { get; }
    }
}