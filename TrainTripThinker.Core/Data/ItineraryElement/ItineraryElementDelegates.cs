using System;

namespace TrainTripThinker.Core.Data
{
    public class ItineraryElementDelegates
    {
        public ItineraryElementDelegates(Action<ItineraryElement> remove, Func<ItineraryElement, bool> moveUp, Func<ItineraryElement, bool> moveDown)
        {
            Remove = remove;
            MoveUp = moveUp;
            MoveDown = moveDown;
        }

        public Action<ItineraryElement> Remove { get; }

        public Func<ItineraryElement, bool> MoveUp { get; }

        public Func<ItineraryElement, bool> MoveDown { get; }
    }
}