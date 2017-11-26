using System;

using TrainTripThinker.Core.Data;

namespace TrainTripThinker.ViewModel
{
    public static class ItineraryElementViewModelFactory
    {
        public static ItineraryElementViewModel CreateViewModel(ItineraryElement model)
        {
            switch (model)
            {
                case TransportElement transportElement:
                    return new TransportElementViewModel(transportElement);
                default:
                    throw new InvalidOperationException("ViewModelが実装されていない型が読み込まれました");
            }
        }
    }
}