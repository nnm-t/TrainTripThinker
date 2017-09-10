using System.Collections.Generic;
using System.Net;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 列車・バス・船・飛行機などの乗り物
    /// </summary>
    public class Transport
    {
        /// <summary>
        /// 乗り物の種類
        /// </summary>
        public TransportType Type { get; set; }

        /// <summary>
        /// 便名
        /// </summary>
        public TransportNumber TransportNumber { get; set; }

        /// <summary>
        /// 路線
        /// </summary>
        public List<string> Route { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 行先
        /// </summary>
        public string Destination { get; set; }
    }
}
