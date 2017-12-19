
using Reactive.Bindings;

using TrainTripThinker.Model.Printing;

namespace TrainTripThinker.ViewModel
{
    public class PrinterSelectorDialogViewModel : ViewModelBase
    {
        public PrinterSelectorDialogViewModel()
        {

        }

        public PrinterSelector<IPrinter> PrinterSelector { get; }

        public ReadOnlyReactiveCollection<PaperSize> PaperSizes { get; }

        public ReactiveProperty<PaperSize> PaperSize { get; }

        public ReadOnlyReactiveCollection<PaperOrientation> PaperOrientations { get; }

        public ReactiveProperty<PaperOrientation> PaperOrientation { get; }

        public ReactiveCommand PrintCommand { get; }

        public ReactiveCommand CancelCommand { get; }
    }
}