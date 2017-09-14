namespace TrainTripThinker.Core.Structs
{
    /// <summary>
    /// 32ビットカラー(アルファチャンネル含む)
    /// </summary>
    public struct Color32
    {
        public Color32(byte red, byte green, byte blue, byte alpha = byte.MaxValue)
        {
            this.Red = red;
            this.Green = green;
            this.Blue = blue;
            this.Alpha = alpha;
        }

        /// <summary>
        /// 国鉄朱色1号
        /// </summary>
        public static Color32 JnrVermilion1 => new Color32(0xEE, 0x77, 0x33);

        /// <summary>
        /// 国鉄青22号
        /// </summary>
        public static Color32 JnrBlue22 => new Color32(0x44, 0xAA, 0xCC);

        /// <summary>
        /// 国鉄黄緑6号
        /// </summary>
        public static Color32 JnrPeaGreen6 => new Color32(0x99, 0xDD, 0x66);

        /// <summary>
        /// 国鉄黄5号
        /// </summary>
        public static Color32 JnrYellow5 => new Color32(0xEE, 0xDD, 0x33);

        /// <summary>
        /// 国鉄青緑1号
        /// </summary>
        public static Color32 JnrEmerald1 => new Color32(0x11, 0x99, 0x88);

        /// <summary>
        /// 透明
        /// </summary>
        public static Color32 Transparent => new Color32(0, 0, 0, 0);

        /// <summary>
        /// 赤
        /// </summary>
        public byte Red { get; }

        /// <summary>
        /// 緑
        /// </summary>
        public byte Green { get; }

        /// <summary>
        /// 青
        /// </summary>
        public byte Blue { get; }

        /// <summary>
        /// アルファチャンネル
        /// </summary>
        public byte Alpha { get; }

    }
}