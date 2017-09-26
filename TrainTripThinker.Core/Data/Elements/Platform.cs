using System.Collections.Generic;

using Prism.Mvvm;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// のりば番号
    /// </summary>
    /// <inheritdoc cref="BindableBase"/>
    public class Platform : BindableBase
    {
        private string prefix;
        private uint? number;
        private string suffix;

        /// <summary>
        /// のりば番号の接頭辞
        /// </summary>
        public string Prefix
        {
            get => prefix;
            set => SetProperty(ref prefix, value);
        }

        /// <summary>
        /// のりば番号
        /// </summary>
        public uint? Number
        {
            get => number;
            set => SetProperty(ref number, value);
        }

        /// <summary>
        /// のりば番号の接尾辞
        /// </summary>
        public string Suffix
        {
            get => suffix;
            set => SetProperty(ref suffix, value);
        }

    }
}