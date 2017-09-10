namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 便名
    /// </summary>
    public class TransportNumber
    {
        /// <summary>
        /// 便名番号の接頭辞
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// 便名番号
        /// </summary>
        public uint? Number { get; set; }

        /// <summary>
        /// 便名番号の接尾辞
        /// </summary>
        public string Suffix { get; set; }
    }
}