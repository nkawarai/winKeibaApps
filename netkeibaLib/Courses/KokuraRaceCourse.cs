namespace netkeibaLib.Courses
{
    /// <summary>
    /// 小倉競馬場
    /// </summary>
    internal class KokuraRaceCourse : IRaceCourse
    {
        private static readonly string _name = "小倉";
        private static readonly string _uriIdentifer = "10";

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IRaceCourse Create()
            => new KokuraRaceCourse();

        /// <summary>
        /// 2文字通称名
        /// </summary>
        public string TwoLetterCode { get => _name; }

        /// <summary>
        /// URIに用いる識別子
        /// </summary>
        public string UriIdentifer { get => _uriIdentifer; }

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        private KokuraRaceCourse() { }
    }
}
