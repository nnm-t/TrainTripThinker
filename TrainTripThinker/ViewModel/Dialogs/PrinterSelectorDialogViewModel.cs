using Reactive.Bindings;

using TrainTripThinker.Model.Printing;

namespace TrainTripThinker.ViewModel
{
    public class PrinterSelectorDialogViewModel : ViewModelBase
    {
        public PrinterSelectorDialogViewModel(PrinterSelector<IPrinter> printerSelector)
        {
            PrinterSelector = printerSelector;
        }

        public PrinterSelector<IPrinter> PrinterSelector { get; }

        public ReactiveCommand PrintCommand { get; }

        public ReactiveCommand CancelCommand { get; }
    }
}