using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using Prism.Mvvm;
using TrainTripThinker.Extensions;
using TrainTripThinker.View;

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
            // ResourcesからItinerariesのViewを引き抜く
            TabControl tabs = Application.Current.Resources["ItinerariesTabControl"] as TabControl;

            if (tabs.Items.Count < 1)
            {
                // タブが無い
                throw new InvalidOperationException();
            }

            if (tabs.SelectedIndex < 0)
            {
                // タブ未選択
                throw new InvalidOperationException();
            }

            try
            {
                // タブ選択済だとここまで走る
                // VisualTreeを辿って選択中のTabを取得
                DependencyObject currentTab = tabs.Children().Skip(tabs.SelectedIndex).First();

                // Tab内のName=ItineraryElementsControlのItemsControlを取得
                IEnumerable<ItemsControl> itemsControls = currentTab.Descendants<ItemsControl>();
                ItemsControl itemsControl = itemsControls.First(x => x.Name.Equals("ItineraryElementsControl"));

                // ページネーション

                // 印刷を実行
                PrinterSelector.SelectedPrinter.Print(null, PaperOrientation.RotateSize(PaperSize.Size));
            }
            catch (InvalidOperationException)
            {
                // 該当するUI要素が無い
            }
        }
    }
}