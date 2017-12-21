
using System.Collections.Generic;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Model.Printing;

namespace TrainTripThinker.ViewModel
{
    public class PrinterSelectorDialogViewModel : ViewModelBase
    {
        private readonly PrintingProvider printingProvider;

        public PrinterSelectorDialogViewModel()
        {
            printingProvider = Main.PrintingProvider;
            PrinterSelector = printingProvider.PrinterSelector;

            PaperSize = printingProvider.ObserveProperty(p => p.PaperSize).ToReactiveProperty();
            PaperOrientation = printingProvider.ObserveProperty(p => p.PaperOrientation).ToReactiveProperty();

            PaperSizes = PrintingProvider.PaperSizes;
            PaperOrientations = PrintingProvider.PaperOrientations;
        }

        public PrinterSelector<Printer> PrinterSelector { get; }

        public IEnumerable<PaperSize> PaperSizes { get; }

        public ReactiveProperty<PaperSize> PaperSize { get; }

        public IEnumerable<PaperOrientation> PaperOrientations { get; }

        public ReactiveProperty<PaperOrientation> PaperOrientation { get; }

        public ReactiveCommand PrintCommand { get; }

        public ReactiveCommand CancelCommand { get; }
    }
}