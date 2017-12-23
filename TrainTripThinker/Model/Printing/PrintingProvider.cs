using System.Collections.Generic;
using Prism.Mvvm;

namespace TrainTripThinker.Model.Printing
{
    public class PrintingProvider : BindableBase
    {
        private PaperSize paperSize;

        private PaperOrientation paperOrientation;

        public PrintingProvider()
        {
            PrinterSelector = PrinterSelector<IPrinter>.FromLocalServer(q => new Printer(q));

            PaperSize = PaperSize.A4;
            PaperOrientation = PaperOrientation.Portrait;
        }

        public static IList<PaperSize> PaperSizes => PaperSize.PaperSizes;

        public static IList<PaperOrientation> PaperOrientations => PaperOrientation.Orientations;

        public PrinterSelector<Printer> PrinterSelector { get; }

        public PaperSize PaperSize
        {
            get => paperSize;
            set => SetProperty(ref paperSize, value);
        }

        public PaperOrientation PaperOrientation
        {
            get => paperOrientation;
            set => SetProperty(ref paperOrientation, value);
        }

        public void Print()
        {
            PrinterSelector.SelectedPrinter.Print(null, PaperOrientation.RotateSize(PaperSize.Size));
        }
    }
}