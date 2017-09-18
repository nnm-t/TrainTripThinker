namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// トイレ有無インターフェイス
    /// </summary>
    public interface IRestRoom
    {
        /// <summary>
        /// トイレの有無
        /// </summary>
        bool HasRestRoom { get; }
    }
}