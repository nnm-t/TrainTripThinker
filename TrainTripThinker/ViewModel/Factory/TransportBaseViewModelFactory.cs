using System;
using TrainTripThinker.Core.Data;

namespace TrainTripThinker.ViewModel
{
    public static class TransportBaseViewModelFactory
    {
        public static TransportBaseViewModel CreateViewMode(TransportBase model)
        {
            switch (model)
            {
                case Train train:
                    return new TrainViewModel(train);
                default:
                    throw new InvalidOperationException();
            }
        }
    }
}