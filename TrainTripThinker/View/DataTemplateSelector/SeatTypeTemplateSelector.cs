using System.Windows;
using System.Windows.Controls;

using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.View
{
    public class SeatTypeTemplateSelector : DataTemplateSelector
    {
        public DataTemplate NonReserved { get; set; }

        public DataTemplate PartOfReserved { get; set; }

        public DataTemplate AllReserved { get; set; }

        public DataTemplate GreenCarNonReserved{ get; set; }

        public DataTemplate GreenCarReserved { get; set; }

        public DataTemplate GranClass { get; set; }

        public DataTemplate B_BedClass { get; set; }

        public DataTemplate A_BedClass { get; set; }

        public DataTemplate Bus4Column { get; set; }

        public DataTemplate Bus3Column { get; set; }

        public DataTemplate Bus2Column { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            var value = (SeatType)item;

            switch (value)
            {
                case SeatType.NonReserved:
                    return NonReserved;
                case SeatType.PartOfReserved:
                    return PartOfReserved;
                case SeatType.AllReserved:
                    return AllReserved;
                case SeatType.GreenCarNonReserved:
                    return GreenCarNonReserved;
                case SeatType.GreenCarReserved:
                    return GreenCarReserved;
                case SeatType.GranClass:
                    return GranClass;
                case SeatType.BClassBed:
                    return B_BedClass;
                case SeatType.AClassBed:
                    return A_BedClass;
                case SeatType.Bus4Columns:
                    return Bus4Column;
                case SeatType.Bus3Columns:
                    return Bus3Column;
                case SeatType.Bus2Columns:
                    return Bus2Column;
                default:
                    return null;
            }
        }
    }
}