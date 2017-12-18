using System;

using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

using Prism.Mvvm;

using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 乗り物の座席種別
    /// </summary>
    /// <inheritdoc cref="FileChangeNotifyBase"/>
    public class TransportSeat : FileChangeNotifyBase
    {
        private SeatType type;

        private string remarks;

        public TransportSeat() : this(SeatType.NonReserved, string.Empty)
        {

        }

        public TransportSeat(SeatType type, string remarks)
        {
            Type = type;
            Remarks = remarks;
        }

        /// <summary>
        /// 座席指定状況
        /// </summary>
        [JsonConverter(typeof(StringEnumConverter))]
        public SeatType Type
        {
            get => type;
            set => SetProperty(ref type, value);
        }

        /// <summary>
        /// 座席備考
        /// </summary>
        public string Remarks
        {
            get => remarks;
            set => SetProperty(ref remarks, value);
        }
    }
}