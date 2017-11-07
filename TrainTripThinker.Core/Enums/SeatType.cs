namespace TrainTripThinker.Core.Enums
{
    /// <summary>
    /// 座席種別
    /// </summary>
    public enum SeatType
    {
        /// <summary>
        /// 普通車自由席
        /// </summary>
        NonReserved = 0,

        /// <summary>
        /// 普通車一部自由席
        /// </summary>
        PartOfReserved = 1,

        /// <summary>
        /// 普通車全車指定席
        /// </summary>
        AllReserved = 2,

        /// <summary>
        /// グリーン車自由席
        /// </summary>
        GreenCarNonReserved = 3,

        /// <summary>
        /// グリーン車指定席
        /// </summary>
        GreenCarReserved = 4,

        /// <summary>
        /// グランクラス
        /// </summary>
        GranClass = 9,

        /// <summary>
        /// B寝台
        /// </summary>
        BClassBed = 10,

        /// <summary>
        /// A寝台
        /// </summary>
        AClassBed = 11,

        /// <summary>
        /// バス4列席
        /// </summary>
        Bus4Columns = 20,

        /// <summary>
        /// バス3列席
        /// </summary>
        Bus3Columns = 21,

        /// <summary>
        /// バス2列席
        /// </summary>
        Bus2Columns = 22
    }
}