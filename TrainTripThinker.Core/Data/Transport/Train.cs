using TrainTripThinker.Core.Structs;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 列車の行程要素
    /// </summary>
    /// <inheritdoc cref="TransportBase"/>
    /// <inheritdoc cref="ITransportClass"/>
    public class Train : TransportBase, ITransportClass, ILineColor, IRestRoom
    {
        private TransportClass transportClass;
        private Color32 lineColor;
        private TrainSeat seat;
        private bool hasRestRoom;

        /// <inheritdoc />
        /// <summary>
        /// 列車種別
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

        /// <summary>
        /// 座席種別
        /// </summary>
        public TrainSeat Seat
        {
            get => seat;
            set => SetProperty(ref seat, value);
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
    }
}