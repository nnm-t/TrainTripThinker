using TrainTripThinker.Core.Structs;

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

        /// <inheritdoc />
        /// <summary>
        /// バス種別
        /// </summary>
        public TransportClass Class { get; }

        /// <inheritdoc />
        /// <summary>
        /// ラインカラー
        /// </summary>
        public Color32 LineColor { get; }

        /// <inheritdoc />
        /// <summary>
        /// トイレ有無
        /// </summary>
        public bool HasRestRoom { get; }

        /// <inheritdoc />
        /// <summary>
        /// 座席種別
        /// </summary>
        public TransportSeat Seat { get; }
    }
}