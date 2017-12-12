using System;
using System.IO;

namespace TrainTripThinker.Core
{
    public class TextWriter : IDisposable
    {
        public TextWriter(string path)
        {
            Path = path;
            StreamWriter = new StreamWriter(Path);
        }

        public string Path { get; }

        public StreamWriter StreamWriter { get; }

        public void Write(string text)
        {
            StreamWriter.Write(text);
        }

        public void Dispose()
        {
            StreamWriter.Dispose();
        }
    }
}