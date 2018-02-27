namespace TrainTripThinker.Core.Utility
{

    /// <summary>
    /// 期間の範囲を表す
    /// </summary>
    public class Period<T> : FileChangeNotifyBase
    {
        private T begin;

        private T end;

        public Period(T begin, T end)
        {
            Begin = begin;
            End = end;
        }

        /// <summary>
        /// 開始
        /// </summary>
        public T Begin
        {
            get => begin;
            set => SetProperty(ref begin, value);
        }

        /// <summary>
        /// 終了
        /// </summary>
        public T End
        {
            get => end;
            set => SetProperty(ref end, value);
        }
    }
}