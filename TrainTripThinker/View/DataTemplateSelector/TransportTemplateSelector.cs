using System;
using System.Windows;
using System.Windows.Controls;

using TrainTripThinker.Core.Data;

namespace TrainTripThinker.View
{
    /// <summary>
    /// <see cref="TransportBase"/>型の派生クラスで<see cref="DataTemplate"/>を分岐させる<see cref="DataTemplateSelector"/>
    /// </summary>
    /// <inheritdoc cref="DataTemplateSelector"/>
    public class TransportTemplateSelector : DataTemplateSelector
    {
        /// <summary>
        /// データが<see cref="Train"/>型のとき用いる<see cref="DataTemplate"/>
        /// </summary>
        public DataTemplate TrainTemplate { get; set; }

        /// <summary>
        /// データが<see cref="Bus"/>型のとき用いる<see cref="DataTemplate"/>
        /// </summary>
        public DataTemplate BusTemplate { get; set; }

        /// <summary>
        /// データが<see cref="Ship"/>型のとき用いる<see cref="DataTemplate"/>
        /// </summary>
        public DataTemplate ShipTemplate { get; set; }

        /// <summary>
        /// データが<see cref="AirCraft"/>型のとき用いる<see cref="DataTemplate"/>
        /// </summary>
        public DataTemplate AirCraftTemplate { get; set; }

        public override DataTemplate SelectTemplate(object item, DependencyObject container)
        {
            switch (item)
            {
                case Train _:
                    return TrainTemplate;
                case Bus _:
                    return BusTemplate;
                default:
                    throw new InvalidOperationException("ContentにはTransportBase型の派生クラスをBindingして下さい");
            }
        }
    }
}