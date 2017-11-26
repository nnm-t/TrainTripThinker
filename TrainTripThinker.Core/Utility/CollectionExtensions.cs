using System.Collections.Generic;

namespace TrainTripThinker.Core.Utility
{
    public static class CollectionExtensions
    {
        public static int LastElementIndex<T>(this ICollection<T> collection)
        {
            return collection.Count - 1;
        }

        public static bool MoveUpElement<T>(this IList<T> list, T element)
        {
            int index = list.IndexOf(element);

            if (index == 0)
            {
                return false;
            }

            list.Remove(element);

            list.Insert(index - 1, element);

            return true;
        }

        public static bool MoveDownElement<T>(this IList<T> list, T element)
        {
            int index = list.IndexOf(element);

            if (index == list.Count - 1)
            {
                return false;
            }

            list.Remove(element);

            list.Insert(index + 1, element);

            return true;
        }
    }
}