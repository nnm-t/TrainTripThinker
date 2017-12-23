using System;
using System.Collections.Generic;
using System.Reactive.Linq;
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

            SelectedPrinterIndex = PrinterSelector.ObserveProperty(p => p.SelectedPrinter)
                .Select(x => PrinterSelector.Printers.IndexOf(x)).ToReactiveProperty();

            PaperSizes = PrintingProvider.PaperSizes;
            PaperOrientations = PrintingProvider.PaperOrientations;

            PaperSizeIndex = printingProvider.ObserveProperty(p => p.PaperSize)
                .Select(x => PrintingProvider.PaperSizes.IndexOf(x)).ToReactiveProperty();
            PaperOrientationIndex = printingProvider.ObserveProperty(p => p.PaperOrientation)
                .Select(x => PrintingProvider.PaperOrientations.IndexOf(x)).ToReactiveProperty();

            PaperSizeIndex.ObserveProperty(x => x.Value)
                .Subscribe(i => printingProvider.PaperSize = PrintingProvider.PaperSizes[i]);
            PaperOrientationIndex.ObserveProperty(x => x.Value).Subscribe(i =>
                printingProvider.PaperOrientation = PrintingProvider.PaperOrientations[i]);

            PrintCommand = new ReactiveCommand();
            PrintCommand.Subscribe(Print);

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

        public ReactiveProperty<int> SelectedPrinterIndex { get; }

        public IEnumerable<PaperSize> PaperSizes { get; }

        public ReactiveProperty<int> PaperSizeIndex { get; }

        public IEnumerable<PaperOrientation> PaperOrientations { get; }

        public ReactiveProperty<int> PaperOrientationIndex { get; }

        public ReactiveCommand PrintCommand { get; }

        public ReactiveCommand CancelCommand { get; }

        public ReactiveCommand ShowDialogCommand { get; }

        public void Print()
        {
            printingProvider.Print();

            IsShowDialog = false;
        }
    }
}