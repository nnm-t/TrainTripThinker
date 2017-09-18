using Prism.Mvvm;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 便名
    /// </summary>
    /// <inheritdoc cref="BindableBase"/>
    public class TransportNumber : BindableBase
    {
        private string prefix;

        private uint? number;

        private string suffix;

        /// <summary>
        /// 便名番号の接頭辞
        /// </summary>
        public string Prefix
        {
            get => prefix;
            set => SetProperty(ref prefix, value);
        }

        /// <summary>
        /// 便名番号
        /// </summary>
        public uint? Number
        {
            get => number;
            set => SetProperty(ref number, value);
        }

        /// <summary>
        /// 便名番号の接尾辞
        /// </summary>
        public string Suffix
        {
            get => suffix;
            set => SetProperty(ref suffix, value);
        }
    }
}