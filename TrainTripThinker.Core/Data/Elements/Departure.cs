using System;
using Newtonsoft.Json;
using Prism.Mvvm;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 駅・停留所・港・空港などのりばからの発着データ
    /// </summary>
    /// <inheritdoc cref="FileChangeNotifyBase"/>
    public class Departure : FileChangeNotifyBase
    {
        private DateTime dateTime;
        private string name;
        private Platform platform;

        public Departure() : this(DateTime.Now)
        {
            
        }

        public Departure(DateTime dateTime)
        {
            DateTime = dateTime;

            Platform = new Platform();
        }

        /// <summary>
        /// 発着時間
        /// </summary>
        /// <remarks>
        /// DatePicker, TimePickerのBindingにはここは指定しない
        /// (値を書き換えた時に関与しないデータを戻してしまうため)
        /// </remarks>
        public DateTime DateTime
        {
            get => dateTime;
            set => SetProperty(ref dateTime, value);
        }

        /// <summary>
        /// 日付
        /// </summary>
        /// <remarks>DatePickerはここにBinding</remarks>
        [JsonIgnore]
        public DateTime Date
        {
            get => dateTime;
            set => SetProperty(ref dateTime, SetNewDate(dateTime, value));
        }

        /// <summary>
        /// 時刻
        /// </summary>
        /// <remarks>TimePickerはここにBinding</remarks>
        [JsonIgnore]
        public DateTime Time
        {
            get => dateTime;
            set => SetProperty(ref dateTime, SetNewTime(dateTime, value));
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

        private DateTime SetNewDate(DateTime oldDate, DateTime newDate)
        {
            return new DateTime(newDate.Year, newDate.Month, newDate.Day, oldDate.Hour, oldDate.Minute, oldDate.Second);
        }

        private DateTime SetNewTime(DateTime oldTime, DateTime newTime)
        {
            return new DateTime(oldTime.Year, oldTime.Month, oldTime.Day, newTime.Hour, newTime.Minute, newTime.Second);
        }
    }
}