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
        protected TransportBase()
        {
            TransportNumber = new TransportNumber();

            Route = new ObservableCollection<string>();
            Route.CollectionChangedAsObservable().Subscribe(OnCollectionChanged);
        }

        /// <summary>
        /// 便名
        /// </summary>
        public TransportNumber TransportNumber { get; set; }

        /// <summary>
        /// 路線
        /// </summary>
        public ObservableCollection<string> Route { get; set; }

        /// <summary>
        /// 名前
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 行先
        /// </summary>
        public string Destination { get; set; }
    }
}
