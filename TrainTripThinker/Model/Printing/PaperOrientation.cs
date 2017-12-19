using System.Collections.Generic;
using System.Printing;

namespace TrainTripThinker.Model.Printing
{
    public class PaperOrientation
    {
        static PaperOrientation()
        {
            Orientations = GetOrientations();
        }

        public PaperOrientation(string name, PageOrientation orientation)
        {
            Name = name;
            Orientation = orientation;
        }

        public static IEnumerable<PaperOrientation> Orientations { get; }

        public static PaperOrientation Portrait => new PaperOrientation("縦", PageOrientation.Portrait);

        public static PaperOrientation LandScape => new PaperOrientation("横", PageOrientation.Landscape);

        public string Name { get; }

        public PageOrientation Orientation { get; }

        private static IEnumerable<PaperOrientation> GetOrientations()
        {
            yield return Portrait;
            yield return LandScape;
        }
    }
}