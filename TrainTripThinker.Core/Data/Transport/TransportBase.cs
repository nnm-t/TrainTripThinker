using System;
using System.Collections.ObjectModel;

using Prism.Mvvm;

using Reactive.Bindings.Extensions;

namespace TrainTripThinker.Core.Data
{
    /// <summary>
    /// 列車・バス・船・飛行機などの乗り物
    /// </summary>
    /// <inheritdoc cref="BindableBase"/>
    public abstract class TransportBase : FileChangeNotifyBase
    {
        private string name;
        private string destination;
        private TransportNumber transportNumber;
        private ObservableCollection<string> routes;

        protected TransportBase()
        {
            TransportNumber = new TransportNumber();

            Routes = new ObservableCollection<string>();
            Routes.CollectionChangedAsObservable().Subscribe(OnCollectionChanged);
        }

        /// <summary>
        /// 便名
        /// </summary>
        public TransportNumber TransportNumber
        {
            get => transportNumber;
            set => SetProperty(ref transportNumber, value);
        }

        /// <summary>
        /// 路線
        /// </summary>
        public ObservableCollection<string> Routes
        {
            get => routes;
            set => SetProperty(ref routes, value);
        }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name
        {
            get => name;
            set => SetProperty(ref name, value);
        }

        /// <summary>
        /// 行先
        /// </summary>
        public string Destination
        {
            get => destination;
            set => SetProperty(ref destination, value);
        }
    }
}
