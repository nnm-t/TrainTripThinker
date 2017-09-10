using System;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 駅・停留所・港・空港などのりばからの発着データ
    /// </summary>
    public class Departure
    {
        /// <summary>
        /// 発着時間
        /// </summary>
        public DateTime DateTime { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// のりば番号
        /// </summary>
        public Platform Platform { get; set; }
    }
}