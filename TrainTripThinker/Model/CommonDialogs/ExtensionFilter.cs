namespace TrainTripThinker.Model
{
    public class ExtensionFilter
    {
        private ExtensionFilter(string filterString)
        {
            this.FilterString = filterString;
        }

        public static ExtensionFilter TTTDocument => new ExtensionFilter(Properties.Settings.Default.TTTDocumentFilter);

        public static ExtensionFilter PNGImage => new ExtensionFilter(Properties.Settings.Default.PNGImageFilter);

        public string FilterString { get; }
    }
}