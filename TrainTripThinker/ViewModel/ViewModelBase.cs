using System;
using System.Reactive.Disposables;

using Prism.Mvvm;

using TrainTripThinker.Model;

namespace TrainTripThinker.ViewModel
{
    public abstract class ViewModelBase : BindableBase, IDisposable
    {
        /// <summary>
        /// Mainインスタンスへの参照
        /// </summary>
        protected readonly TttMain Main;

        protected ViewModelBase()
        {
            Main = ModelManager<TttMain>.Instance;

            Disposables = new CompositeDisposable();
        }

        ~ViewModelBase()
        {
            Disposables.Dispose();
        }

        protected CompositeDisposable Disposables { get; }

        public void Dispose()
        {
            Disposables.Dispose();
        }
    }
}