namespace TrainTripThinker.Core.Utility
{
    /// <summary>
    /// 期間の範囲を表す
    /// </summary>
    public class Period<T>
    {
        public Period(T begin, T end)
        {
            Begin = begin;
            End = end;
        }

        /// <summary>
        /// 開始
        /// </summary>
        public T Begin { get; }

        /// <summary>
        /// 終了
        /// </summary>
        public T End { get; }
    }
}