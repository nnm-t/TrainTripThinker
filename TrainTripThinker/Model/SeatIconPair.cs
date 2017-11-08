
using System.Windows;

using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.Model
{
    /// <summary>
    /// 座席とアイコンのペア
    /// </summary>
    public class SeatIconPair
    {
        /// <summary>
        /// 座席種類
        /// </summary>
        public SeatType SeatType { get; set; }

        /// <summary>
        /// アイコンに相当する<see cref="FrameworkElement"/>
        /// </summary>
        public FrameworkElement Icon { get; set; }
    }
}
