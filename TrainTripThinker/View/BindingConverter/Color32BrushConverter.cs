using System;
using System.Globalization;
using System.Windows.Data;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Extensions;

namespace TrainTripThinker.View
{ 
    public class Color32BrushConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = (Color32)(value ?? throw new ArgumentNullException(nameof(value)));

            return color.ToSolidColorBrush();
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return value;
        }
    }
}