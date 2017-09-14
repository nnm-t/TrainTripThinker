using Prism.Mvvm;

using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.Core.Data
{
    public class TrainSeat: BindableBase
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
    }
}