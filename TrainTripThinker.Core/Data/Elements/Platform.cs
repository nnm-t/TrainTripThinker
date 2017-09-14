namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// のりば番号
    /// </summary>
    public class Platform
    {
        /// <summary>
        /// のりば番号の接頭辞
        /// </summary>
        public string Prefix { get; set; }

        /// <summary>
        /// のりば番号
        /// </summary>
        public uint? Number { get; set; }

        /// <summary>
        /// のりば番号の接尾辞
        /// </summary>
        public string Suffix { get; set; }
    }
}