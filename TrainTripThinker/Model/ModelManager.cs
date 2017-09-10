namespace TrainTripThinker.Model
{
    /// <summary>
    /// SingletonパターンでModelを管理するクラス
    /// </summary>
    /// <typeparam name="T">Modelの型</typeparam>
    public static class ModelManager<T>
        where T : new()
    {
        /// <summary>
        /// Modelのインスタンスを生成するコンストラクタ
        /// </summary>
        static ModelManager()
        {
            Instance = new T();
        }

        /// <summary>
        /// Modelのインスタンス
        /// </summary>
        public static T Instance { get; }
    }
}