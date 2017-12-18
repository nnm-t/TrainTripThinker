using System.Collections;
using System.Windows;

namespace TrainTripThinker.Model.Printing
{
    public interface IPrinter
    {
        string Name { get; }

        void Print(IEnumerable pages, Size pageSize);
    }
}