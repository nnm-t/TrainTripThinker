using System.Collections.Generic;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 32ビットカラー(アルファチャンネル含む)
    /// </summary>
    public struct Color32
    {
        /// <summary>
        /// コンストラクタ
        /// </summary>
        /// <param name="r">赤成分</param>
        /// <param name="g">緑成分</param>
        /// <param name="b">青成分</param>
        /// <param name="a">アルファチャンネル</param>
        public Color32(byte r, byte g, byte b, byte a = byte.MaxValue)
        {
            R = r;
            G = g;
            B = b;
            A = a;
        }

        /// <summary>
        /// 黒
        /// </summary>
        public static Color32 Black => new Color32(0x00, 0x00, 0x00);

        /// <summary>
        /// 白
        /// </summary>
        public static Color32 White => new Color32(0xFF, 0xFF, 0xFF);

        /// <summary>
        /// 赤
        /// </summary>
        public static Color32 Red => new Color32(0xFF, 0x00, 0x00);

        /// <summary>
        /// オレンジ
        /// </summary>
        public static Color32 Orange => new Color32(0xFF, 0xA5, 0x00);

        /// <summary>
        /// 黄緑
        /// </summary>
        public static Color32 Lime => new Color32(0x00, 0xFF, 0x00);

        /// <summary>
        /// 青
        /// </summary>
        public static Color32 Blue => new Color32(0x00, 0x00, 0xFF);

        /// <summary>
        /// 黄色
        /// </summary>
        public static Color32 Yellow => new Color32(0xFF, 0xFF, 0x00);

        /// <summary>
        /// ピンク
        /// </summary>
        public static Color32 Pink => new Color32(0xFF, 0x69, 0xB4);

        /// <summary>
        /// 水色
        /// </summary>
        public static Color32 Aqua => new Color32(0x00, 0xBF, 0xFF);

        /// <summary>
        /// 茶色
        /// </summary>
        public static Color32 Brown => new Color32(0xA5, 0x2A, 0x2A);

        /// <summary>
        /// 灰色
        /// </summary>
        public static Color32 Gray => new Color32(0x80, 0x80, 0x80);

        /// <summary>
        /// 緑
        /// </summary>
        public static Color32 Green => new Color32(0x00, 0x80, 0x00);

        /// <summary>
        /// 紺
        /// </summary>
        public static Color32 Navy => new Color32(0x00, 0x00, 0x80);

        /// <summary>
        /// 紫
        /// </summary>
        public static Color32 Purple => new Color32(0x80, 0x00, 0x80);

        /// <summary>
        /// 国鉄赤2号
        /// </summary>
        public static Color32 JnrRed2 => new Color32(0xBB, 0x33, 0x22);

        /// <summary>
        /// 国鉄赤11号
        /// </summary>
        public static Color32 JnrRed11 => new Color32(0xCC, 0x44, 0x00);

        /// <summary>
        /// 国鉄赤14号
        /// </summary>
        public static Color32 JnrRed14 => new Color32(0xDD, 0x33, 0x55);

        /// <summary>
        /// 国鉄ぶどう色2号
        /// </summary>
        public static Color32 JnrWine2 => new Color32(0x77, 0x44, 0x33);

        /// <summary>
        /// 国鉄朱色1号
        /// </summary>
        public static Color32 JnrVermilion1 => new Color32(0xEE, 0x77, 0x33);

        /// <summary>
        /// 国鉄朱色4号
        /// </summary>
        public static Color32 JnrVermilion4 => new Color32(0xDD, 0x55, 0x22);

        /// <summary>
        /// 国鉄朱色5号
        /// </summary>
        public static Color32 JnrVermilion5 => new Color32(0xDD, 0x66, 0x33);

        /// <summary>
        /// 国鉄黄1号
        /// </summary>
        public static Color32 JnrYellow1 => new Color32(0xFF, 0xDD, 0x00);

        /// <summary>
        /// 国鉄黄5号
        /// </summary>
        public static Color32 JnrYellow5 => new Color32(0xEE, 0xDD, 0x33);

        /// <summary>
        /// 国鉄クリーム1号
        /// </summary>
        public static Color32 JnrCream1 => new Color32(0xFF, 0xEE, 0xCC);

        /// <summary>
        /// 国鉄クリーム4号
        /// </summary>
        public static Color32 JnrCream4 => new Color32(0xEE, 0xEE, 0xBB);

        /// <summary>
        /// 国鉄クリーム10号
        /// </summary>
        public static Color32 JnrCream10 => new Color32(0xFF, 0xFA, 0xF5);

        /// <summary>
        /// 国鉄黄かん色
        /// </summary>
        public static Color32 JnrOrange => new Color32(0xFF, 0x99, 0x33);

        /// <summary>
        /// 国鉄緑2号
        /// </summary>
        public static Color32 JnrGreen2 => new Color32(0x33, 0x66, 0x33);

        /// <summary>
        /// 国鉄緑15号
        /// </summary>
        public static Color32 JnrGreen15 => new Color32(0x22, 0x88, 0x66);

        /// <summary>
        /// 国鉄黄緑6号
        /// </summary>
        public static Color32 JnrLime6 => new Color32(0x99, 0xDD, 0x66);

        /// <summary>
        /// 国鉄青緑1号
        /// </summary>
        public static Color32 JnrEmerald1 => new Color32(0x11, 0x99, 0x88);

        /// <summary>
        /// 国鉄青15号
        /// </summary>
        public static Color32 JnrBlue15 => new Color32(0x22, 0x44, 0x99);

        /// <summary>
        /// 国鉄青20号
        /// </summary>
        public static Color32 JnrBlue20 => new Color32(0x22, 0x55, 0xAA);

        /// <summary>
        /// 国鉄青22号
        /// </summary>
        public static Color32 JnrBlue22 => new Color32(0x44, 0xAA, 0xCC);

        /// <summary>
        /// 国鉄青22号特色(吹田工場)
        /// </summary>
        public static Color32 JnrBlue22Suita => new Color32(0x22, 0xAA, 0xBB);

        /// <summary>
        /// 国鉄黒
        /// </summary>
        public static Color32 JnrBlack => new Color32(0x22, 0x22, 0x22);

        /// <summary>
        /// 国鉄ねずみ色1号
        /// </summary>
        public static Color32 JnrGray1 => new Color32(0xAA, 0xAA, 0xAA);

        /// <summary>
        /// 国鉄灰色9号
        /// </summary>
        public static Color32 JnrGray9 => new Color32(0xF9, 0xF9, 0xF9);

        /// <summary>
        /// 国鉄白3号
        /// </summary>
        public static Color32 JnrWhite3 => new Color32(0xFE, 0xFE, 0xFE);

        /// <summary>
        /// 透明
        /// </summary>
        public static Color32 Transparent => new Color32(0, 0, 0, 0);

        /// <summary>
        /// 京急バーミリオン
        /// </summary>
        public static Color32 KeikyuVermilion => new Color32(0xCC, 0x22, 0x22);

        /// <summary>
        /// 名鉄スカーレット
        /// </summary>
        public static Color32 MeitetsuScarlet => new Color32(0xCC, 0x44, 0x22);

        /// <summary>
        /// 阪急マルーン
        /// </summary>
        public static Color32 HankyuMaroon => new Color32(0x77, 0x33, 0x33);

        /// <summary>
        /// 東武セイジクリーム
        /// </summary>
        public static Color32 TobuSageCream => new Color32(0xFF, 0xFA, 0xDD);

        /// <summary>
        /// 東武ライトブルー
        /// </summary>
        public static Color32 TobuLightBlue => new Color32(0x33, 0xAA, 0xEE);

        /// <summary>
        /// 東武ジャスミンホワイト
        /// </summary>
        public static Color32 TobuJasmineWhite => new Color32(0xFC, 0xFC, 0xFF);

        /// <summary>
        /// 西武ラズベリー
        /// </summary>
        public static Color32 SeibuRaspberry => new Color32(0xBB, 0x55, 0x44);

        /// <summary>
        /// 西武イエロー
        /// </summary>
        public static Color32 SeibuYellow => new Color32(0xEE, 0xEE, 0x44);

        /// <summary>
        /// 西武ベージュ
        /// </summary>
        public static Color32 SeibuBeige => new Color32(0xBB, 0xBB, 0x99);

        /// <summary>
        /// 小田急ロイヤルブルー
        /// </summary>
        public static Color32 OdakyuRoyalBlue => new Color32(0x22, 0x66, 0xBB);

        /// <summary>
        /// 京王レッド
        /// </summary>
        public static Color32 KeioRed => new Color32(0xDD, 0x33, 0x77);

        /// <summary>
        /// 京王ブルー
        /// </summary>
        public static Color32 KeioBlue => new Color32(0x33, 0x33, 0x88);

        /// <summary>
        /// 赤成分
        /// </summary>
        public byte R { get; }

        /// <summary>
        /// 緑成分
        /// </summary>
        public byte G { get; }

        /// <summary>
        /// 青成分
        /// </summary>
        public byte B { get; }

        /// <summary>
        /// アルファチャンネル
        /// </summary>
        public byte A { get; }

    }
}