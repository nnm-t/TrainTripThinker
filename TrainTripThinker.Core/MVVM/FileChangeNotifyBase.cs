using System;
using System.Collections.Specialized;
using System.Runtime.CompilerServices;

using Prism.Mvvm;

namespace TrainTripThinker.Core
{
    public class FileChangeNotifyBase : BindableBase
    {
        protected override bool SetProperty<T>(ref T storage, T value, [CallerMemberName] string propertyName = null)
        {
            bool isNotify = base.SetProperty(ref storage, value, propertyName);

            if (isNotify)
            {
                NotifyFileChanged();
            }

            return isNotify;
        }

        protected override bool SetProperty<T>(ref T storage, T value, Action onChanged, [CallerMemberName] string propertyName = null)
        {
            bool isNotify = base.SetProperty(ref storage, value, onChanged, propertyName);

            if (isNotify)
            {
                NotifyFileChanged();
            }

            return isNotify;
        }

        protected virtual void NotifyFileChanged()
        {
            Main.IsFileChanged = true;
        }

        protected virtual void OnCollectionChanged(NotifyCollectionChangedEventArgs args)
        {
            NotifyFileChanged();
        }
    }
}