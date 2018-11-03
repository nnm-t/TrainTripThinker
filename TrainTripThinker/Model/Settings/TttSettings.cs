using Prism.Mvvm;

namespace TrainTripThinker.Model
{
    public class TttSettings : BindableBase
    {
        private string themePath;

        private string baseColor;

        private string accentColor;

        private string themeColor;

        public string ThemePath
        {
            get => themePath;
            set => SetProperty(ref themePath, value);
        }

        public string BaseColor
        {
            get => baseColor;
            set => SetProperty(ref baseColor, value);
        }

        public string AccentColor
        {
            get => accentColor;
            set => SetProperty(ref accentColor, value);
        }

        public string ThemeColor
        {
            get => themeColor;
            set => SetProperty(ref themeColor, value);
        }
    }
}