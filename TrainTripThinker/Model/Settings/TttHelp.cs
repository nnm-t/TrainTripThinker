using System.Diagnostics;

namespace TrainTripThinker.Model
{
    public class TttHelp
    {
        public static void AccessToWiki()
        {
            Process.Start(Properties.Settings.Default.WikiUrl);
        }

        public static void AccessToGitHub()
        {
            Process.Start(Properties.Settings.Default.GitHubUrl);
        }

        public static void AccessToWebSite()
        {
            Process.Start(Properties.Settings.Default.WebSiteUrl);
        }
    }
}