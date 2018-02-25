
namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// バスの行程要素
    /// </summary>
    /// <inheritdoc cref="TransportBase"/>
    public class Bus : TransportBase, ITransportClass, ILineColor, IRestRoom, ITransportSeat
    {
        private TransportClass transportClass;
        private Color32 lineColor;
        private bool hasRestRoom;
        private TransportSeat seat;

        public Bus()
        {
            Class = TransportClass.Local;
            LineColor = Color32.Black;
            Seat = new TransportSeat();
        }

        /// <inheritdoc />
        /// <summary>
        /// バス種別
        /// </summary>
        public TransportClass Class
        {
            get => transportClass;
            set => SetProperty(ref transportClass, value);
        }

        /// <inheritdoc />
        /// <summary>
        /// ラインカラー
        /// </summary>
        public Color32 LineColor
        {
            get => lineColor;
            set => SetProperty(ref lineColor, value);
        }

        /// <inheritdoc />
        /// <summary>
        /// トイレ有無
        /// </summary>
        public bool HasRestRoom
        {
            get => hasRestRoom;
            set => SetProperty(ref hasRestRoom, value);
        }

        /// <inheritdoc />
        /// <summary>
        /// 座席種別
        /// </summary>
        public TransportSeat Seat
        {
            get => seat;
            set => SetProperty(ref seat, value);
        }
    }
}