using System;
using System.Windows;

namespace TrainTripThinker.Model
{
    public class ThemeSelector
    {
        public ThemeSelector(TttSettings settings)
        {
            Load(settings.ThemePath);
        }

        public ResourceDictionary ResourceDictionary { get; private set; }

        public void Load(string path)
        {
            Load(new Uri(path));
        }

        public void Load(Uri uri)
        {
            if (ResourceDictionary != null)
            {
                RemoveMergedDictionaries();
            }

            ResourceDictionary = new ResourceDictionary { Source = uri };

            AddMergedDictionaries();
        }

        private void AddMergedDictionaries()
        {
            Application.Current.Resources.MergedDictionaries.Add(ResourceDictionary);
        }

        private void RemoveMergedDictionaries()
        {
            Application.Current.Resources.MergedDictionaries.Remove(ResourceDictionary);
        }

    }
}