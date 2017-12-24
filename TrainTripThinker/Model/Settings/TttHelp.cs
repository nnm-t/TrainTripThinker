using System.Diagnostics;

namespace TrainTripThinker.Model
{
    public class TttHelp
    {
        public static void AccessToWiki()
        {
            Process.Start(Properties.Settings.Default.WikiUrl);
        }
    }
}