using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows;
using System.Windows.Data;

using TrainTripThinker.Core.Data;

namespace TrainTripThinker.View
{
    public class TransportClassConverter : IValueConverter
    {
        private readonly string arrayKey = "TransportClasses";

        private TransportClass[] TransportClasses
        {
            get => Application.Current.Resources[arrayKey] as TransportClass[];
            set => Application.Current.Resources[arrayKey] = value;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TransportClass data))
            {
                throw new InvalidOperationException(nameof(value));
            }

            TransportClass match = TransportClasses.FirstOrDefault(x => x.Equals(data));

            if (match == null)
            {
                // XAMLの配列に無い時は動的に追加する
                IList<TransportClass> list = TransportClasses.ToList();
                list.Add(data);
                TransportClasses = list.ToArray();
            }

            return data;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (!(value is TransportClass data))
            {
                throw new InvalidOperationException(nameof(value));
            }

            return data;
        }
    }
}