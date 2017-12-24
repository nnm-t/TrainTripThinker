using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

using TrainTripThinker.Core.Data;
using TrainTripThinker.Model;

namespace TrainTripThinker.View
{
    public class ColorNameConverter : IValueConverter

    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var color = (Color32)value;
            var colors = Application.Current.Resources["ColorNameArray"] as IEnumerable<ColorName>;
            var pair = colors?.First(x => x.Color.Equals(color)) ?? new ColorName { Color = color };

            return pair;

        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as ColorName)?.Color;
        }
    }
}