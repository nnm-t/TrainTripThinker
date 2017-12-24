using System;
using System.Collections.Generic;
using System.Linq;
using System.Printing;
using System.Windows;

namespace TrainTripThinker.Model.Printing
{
    public class PaperOrientation
    {
        static PaperOrientation()
        {
            Orientations = GetOrientations().ToList();
        }

        public PaperOrientation(string name, PageOrientation orientation)
        {
            Name = name;
            Orientation = orientation;
        }

        public static IList<PaperOrientation> Orientations { get; }

        public static PaperOrientation Portrait => new PaperOrientation("縦", PageOrientation.Portrait);

        public static PaperOrientation LandScape => new PaperOrientation("横", PageOrientation.Landscape);

        public string Name { get; }

        public PageOrientation Orientation { get; }

        public override bool Equals(object obj)
        {
            PaperOrientation other = obj as PaperOrientation ?? throw new InvalidOperationException();

            return Name.Equals(other.Name) && Orientation == other.Orientation;
        }

        public override int GetHashCode()
        {
            return Name.GetHashCode() * Orientation.GetHashCode();
        }

        public Size RotateSize(Size size)
        {
            return Orientation == PageOrientation.Landscape ? size.Rotate90() : size;
        }

        private static IEnumerable<PaperOrientation> GetOrientations()
        {
            yield return Portrait;
            yield return LandScape;
        }
    }
}