
using System.Collections.Generic;
using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Model.Printing;

namespace TrainTripThinker.ViewModel
{
    public class PrinterSelectorDialogViewModel : ViewModelBase
    {
        private readonly PrintingProvider printingProvider;

        private bool isShowDialog;

        public PrinterSelectorDialogViewModel()
        {
            printingProvider = Main.PrintingProvider;
            PrinterSelector = printingProvider.PrinterSelector;

            PaperSize = printingProvider.ObserveProperty(p => p.PaperSize).ToReactiveProperty();
            PaperOrientation = printingProvider.ObserveProperty(p => p.PaperOrientation).ToReactiveProperty();

            PaperSizes = PrintingProvider.PaperSizes;
            PaperOrientations = PrintingProvider.PaperOrientations;

            CancelCommand = new ReactiveCommand();
            CancelCommand.Subscribe(() => IsShowDialog = false);

            ShowDialogCommand = new ReactiveCommand();
            ShowDialogCommand.Subscribe(() => IsShowDialog = true);
        }

        public bool IsShowDialog
        {
            get => isShowDialog;
            set => SetProperty(ref isShowDialog, value);
        }

        public PrinterSelector<Printer> PrinterSelector { get; }

        public IEnumerable<PaperSize> PaperSizes { get; }

        public ReactiveProperty<PaperSize> PaperSize { get; }

        public IEnumerable<PaperOrientation> PaperOrientations { get; }

        public ReactiveProperty<PaperOrientation> PaperOrientation { get; }

        public ReactiveCommand PrintCommand { get; }

        public ReactiveCommand CancelCommand { get; }

        public ReactiveCommand ShowDialogCommand { get; }
    }
}