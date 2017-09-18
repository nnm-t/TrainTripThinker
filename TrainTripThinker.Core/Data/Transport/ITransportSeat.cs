namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 座席種別インターフェイス
    /// </summary>
    public interface ITransportSeat
    {
        /// <summary>
        /// 座席種別
        /// </summary>
        TransportSeat Seat { get; }
    }
}