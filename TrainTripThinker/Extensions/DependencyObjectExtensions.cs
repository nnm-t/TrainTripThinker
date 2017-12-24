using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows;
using System.Windows.Media;

namespace TrainTripThinker.Extensions
{
    public static class DependencyObjectExtensions
    {
        public static IEnumerable<DependencyObject> Children(this DependencyObject obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            int count = VisualTreeHelper.GetChildrenCount(obj);
            if (count == 0)
            {
                yield break;
            }

            for (var i = 0; i < count; i++)
            {
                yield return VisualTreeHelper.GetChild(obj, i);
            }
        }

        public static IEnumerable<DependencyObject> Descendants(this DependencyObject obj)
        {
            if (obj == null)
            {
                throw new ArgumentNullException(nameof(obj));
            }

            foreach (DependencyObject child in obj.Children())
            {
                yield return child;
                foreach (DependencyObject grandChild in child.Descendants())
                {
                    yield return grandChild;
                }
            }
        }

        public static IEnumerable<T> Children<T>(this DependencyObject obj)
            where T : DependencyObject
        {
            return obj.Children().OfType<T>();
        }

        public static IEnumerable<T> Descendants<T>(this DependencyObject obj)
            where T: DependencyObject
        {
            return obj.Descendants().OfType<T>();
        }
    }
}