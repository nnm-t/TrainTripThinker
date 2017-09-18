using Prism.Mvvm;

using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 乗り物の座席種別
    /// </summary>
    /// <inheritdoc cref="BindableBase"/>
    public class TransportSeat: BindableBase
    {
        private SeatReservation reservation;
        private string seatType;

        /// <summary>
        /// 座席指定状況
        /// </summary>
        public SeatReservation Reservation
        {
            get => reservation;
            set => SetProperty(ref reservation, value);
        }

        /// <summary>
        /// 座席タイプ
        /// </summary>
        public string SeatType
        {
            get => seatType;
            set => SetProperty(ref seatType, value);
        }
    }
}