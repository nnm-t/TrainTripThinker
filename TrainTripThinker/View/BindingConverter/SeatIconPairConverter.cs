using System;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

using TrainTripThinker.Core.Enums;
using TrainTripThinker.Model;

namespace TrainTripThinker.View
{
    public class SeatIconPairConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            var seatType = (SeatType)value;
            var pairs = (Application.Current.Resources["SeatTypeIconArray"] as ArrayExtension).Items
                .Cast<SeatIconPair>();

            return pairs?.First(x => x.SeatType.Equals(seatType));
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            return (value as SeatIconPair)?.SeatType;
        }
    }
}