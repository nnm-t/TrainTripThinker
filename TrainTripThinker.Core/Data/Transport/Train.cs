
using System;

using TrainTripThinker.Core.Enums;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 列車の行程要素
    /// </summary>
    /// <inheritdoc cref="TransportBase"/>
    /// <inheritdoc cref="ITransportClass"/>
    public class Train : TransportBase, ITransportClass, ILineColor, IRestRoom, ITransportSeat
    {
        private TransportClass transportClass;
        private Color32 lineColor;
        private TransportSeat seat;
        private bool hasRestRoom;
        private MealType mealType;

        public Train()
        {
            Seat = new TransportSeat();
            Class = TransportClass.Local;
            LineColor = Color32.Black;
        }

        /// <inheritdoc />
        /// <summary>
        /// 列車種別
        /// </summary>
        public TransportClass Class
        {
            get => transportClass;
            set => SetProperty(ref transportClass, value);
        }

        /// <inheritdoc />
        /// <summary>
        /// ラインカラー
        /// </summary>
        public Color32 LineColor
        {
            get => lineColor;
            set => SetProperty(ref lineColor, value);
        }

        /// <inheritdoc />
        /// <summary>
        /// 座席種別
        /// </summary>
        public TransportSeat Seat
        {
            get => seat;
            set => SetProperty(ref seat, value);
        }

        /// <inheritdoc />
        /// <summary>
        /// トイレ有無
        /// </summary>
        public bool HasRestRoom
        {
            get => hasRestRoom;
            set => SetProperty(ref hasRestRoom, value);
        }

        /// <summary>
        /// 供食設備
        /// </summary>
        public MealType MealType
        {
            get => mealType;
            set => SetProperty(ref mealType, value);
        }
    }
}