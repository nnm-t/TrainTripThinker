using System;
using System.Windows;

namespace TrainTripThinker.View
{
    public class DataTemplateHolder : DependencyObject
    {
        public static readonly DependencyProperty ValueProperty
            = DependencyProperty.Register(nameof(Value), typeof(Type), typeof(DataTemplateHolder));

        public static readonly DependencyProperty DataTemplateProperty
            = DependencyProperty.Register(nameof(DataTemplate), typeof(DataTemplate), typeof(DataTemplateHolder));

        public Type Value
        {
            get => GetValue(ValueProperty) as Type;
            set => SetValue(ValueProperty, value);
        }

        public DataTemplate DataTemplate
        {
            get => GetValue(DataTemplateProperty) as DataTemplate;
            set => SetValue(ValueProperty, value);
        }
    }
}