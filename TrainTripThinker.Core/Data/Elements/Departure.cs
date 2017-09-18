using System;

using Prism.Mvvm;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 駅・停留所・港・空港などのりばからの発着データ
    /// </summary>
    /// <inheritdoc cref="BindableBase"/>
    public class Departure : BindableBase
    {
        private DateTime dateTime;
        private string name;
        private Platform platform;

        /// <summary>
        /// 発着時間
        /// </summary>
        public DateTime DateTime
        {
            get => dateTime;
            set => SetProperty(ref dateTime, value);
        }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        /// <summary>
        /// のりば番号
        /// </summary>
        public Platform Platform
        {
            get => platform;
            set => SetProperty(ref platform, value);
        }
    }
}