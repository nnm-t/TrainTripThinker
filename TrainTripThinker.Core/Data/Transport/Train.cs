namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 列車の行程要素
    /// </summary>
    /// <inheritdoc cref="TransportBase"/>
    /// <inheritdoc cref="ITransportClass"/>
    public class Train : TransportBase, ITransportClass
    {
        private TransportClass transportClass;

        private TrainSeat seat;

        /// <inheritdoc />
        /// <summary>
        /// 列車種別
        /// </summary>
        public TransportClass Class
        {
            get => transportClass;
            set => SetProperty(ref transportClass, value);
        }

        /// <summary>
        /// 座席種別
        /// </summary>
        public TrainSeat Seat
        {
            get => seat;
            set => SetProperty(ref seat, value);
        }
    }
}