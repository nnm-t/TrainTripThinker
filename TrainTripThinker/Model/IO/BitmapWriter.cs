using System.IO;
using System.Windows.Media.Imaging;

namespace TrainTripThinker.Model
{
    public class BitmapWriter
    {
        private readonly BitmapSource source;

        private readonly BitmapEncoder encoder;

        public BitmapWriter(BitmapSource source)
        {
            this.source = source;
            encoder = new PngBitmapEncoder();
        }

        public BitmapWriter(BitmapSource source, BitmapEncoder encoder) : this(source)
        {
            this.encoder = encoder;
        }

        public void Save(string filePath)
        {
            using (var fs = new FileStream(filePath, FileMode.Create))
            {
                encoder.Frames.Add(BitmapFrame.Create(source));
                encoder.Save(fs);
            }
        }
    }
}