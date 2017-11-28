using System;
using System.Windows;
using System.Windows.Controls;

using TrainTripThinker.ViewModel;

namespace TrainTripThinker.View
{
    public class ItineraryElementViewModelTemplateSelector : DataTemplateSelector
    {
        public DataTemplate TransportElementTemplate { get; set; }

        public DataTemplate PeriodElementTemplate { get; set; }

        public DataTemplate ItineraryElementTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            // 型スイッチは上から順に判定されるので基本クラスは下に書くこと
            switch (item)
            {
                case TransportElementViewModel _:
                    return TransportElementTemplate;
                case PeriodElementViewModel _:
                    return PeriodElementTemplate;
                case ItineraryElementViewModel _:
                    return ItineraryElementTemplate;
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}