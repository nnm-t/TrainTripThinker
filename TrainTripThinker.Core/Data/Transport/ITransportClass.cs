namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 乗り物の種別を実装するインターフェイス
    /// </summary>
    public interface ITransportClass
    {
        /// <summary>
        /// 種別
        /// </summary>
        TransportClass Class { get; }
    }
}