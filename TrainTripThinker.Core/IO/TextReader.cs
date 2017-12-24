using System;
using System.IO;
using System.Text;

namespace TrainTripThinker.Core
{
    public class TextReader : IDisposable
    {

        public TextReader(string path)
        {
            Path = path;
            StreamReader = new StreamReader(path);
        }

        public string Path { get; }

        public StreamReader StreamReader { get; }

        public string Read()
        {
            return StreamReader.ReadToEnd();
        }

        public void Dispose()
        {
            StreamReader.Close();
        }
    }
}