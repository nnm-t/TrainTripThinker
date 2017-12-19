using System.Printing;
using System.Windows;

namespace TrainTripThinker
{
    public static class SizeExtensions
    {
        public static Size Rotate90(this Size size)
        {
            return new Size(size.Height, size.Width);
        }

        public static PageMediaSize ToPageMediaSize(this Size size)
        {
            return new PageMediaSize(size.Width, size.Height);
        }
    }
}