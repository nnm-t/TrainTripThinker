using Prism.Mvvm;
using TrainTripThinker.Core;

namespace TrainTripThinker.Model
{
    public class About : BindableBase
    {
        private string licenseText;

        public About()
        {
            using (var textReader = new TextReader(Properties.Settings.Default.LicenseTextPath))
            {
                LicenseText = textReader.Read();
            }
        }

        public string LicenseText
        {
            get => licenseText;

            set => SetProperty(ref licenseText, value);
        }
    }
}