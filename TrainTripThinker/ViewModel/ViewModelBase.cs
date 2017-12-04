using Prism.Mvvm;

using TrainTripThinker.Model;

namespace TrainTripThinker.ViewModel
{
    public abstract class ViewModelBase : BindableBase
    {
        /// <summary>
        /// Mainインスタンスへの参照
        /// </summary>
        protected readonly TttMain Main;

        protected ViewModelBase()
        {
            Main = ModelManager<TttMain>.Instance;
        }
    }
}