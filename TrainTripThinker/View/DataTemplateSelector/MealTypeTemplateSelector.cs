using System;
using System.Windows;
using System.Windows.Controls;

using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.View
{
    public class MealTypeTemplateSelector :DataTemplateSelector
    {
        public DataTemplate NoneTemplate { get; set; }

        public DataTemplate WagonTemplate { get; set; }

        public DataTemplate DiningCarTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var value = (MealType)item;

            switch (value)
            {
                case MealType.None:
                    return NoneTemplate;
                case MealType.Wagon:
                    return WagonTemplate;
                case MealType.DiningCar:
                    return DiningCarTemplate;
                default:
                    return null;
            }
        }
    }
}