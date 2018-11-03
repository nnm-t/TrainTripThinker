using Reactive.Bindings;
using Reactive.Bindings.Extensions;
using TrainTripThinker.Model;

namespace TrainTripThinker.ViewModel
{
    public class SettingsViewModel : ViewModelBase
    {
        public SettingsViewModel(TttSettings model)
        {
            ThemePath = model.ObserveProperty(m => m.ThemePath).ToReactiveProperty();
            BaseColor = model.ObserveProperty(m => m.BaseColor).ToReactiveProperty();
            AccentColor = model.ObserveProperty(m => m.AccentColor).ToReactiveProperty();
            ThemeColor = model.ObserveProperty(m => m.ThemeColor).ToReactiveProperty();
        }

        public ReactiveProperty<string> ThemePath { get; }

        public ReactiveProperty<string> BaseColor { get; }
        
        public ReactiveProperty<string> AccentColor { get; }

        public ReactiveProperty<string> ThemeColor { get; }
    }
}