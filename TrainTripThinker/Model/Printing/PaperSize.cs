using System.Collections.Generic;
using System.Windows;

namespace TrainTripThinker.Model.Printing
{
    public class PaperSize
    {
        static PaperSize()
        {
            PaperSizes = GetPaperSizes();
        }

        public PaperSize(string name, Size size)
        {
            Name = name;
            Size = size;
        }

        public static IEnumerable<PaperSize> PaperSizes { get; }

        public static PaperSize A3 => new PaperSize(nameof(A3), new Size(297, 420));

        public static PaperSize A4 => new PaperSize(nameof(A4), new Size(210, 297));

        public static PaperSize A5 => new PaperSize(nameof(A5), new Size(148, 210));

        public static PaperSize A6 => new PaperSize(nameof(A6), new Size(105, 148));

        public static PaperSize B4 => new PaperSize(nameof(B4), new Size(257, 364));

        public static PaperSize B5 => new PaperSize(nameof(B5), new Size(182, 257));

        public static PaperSize B6 => new PaperSize(nameof(B6), new Size(128, 182));

        public string Name { get; }

        public Size Size { get; }

        private static IEnumerable<PaperSize> GetPaperSizes()
        {
            yield return A3;
            yield return B4;
            yield return A4;
            yield return B5;
            yield return A5;
            yield return B6;
            yield return A6;
        }
    }
}