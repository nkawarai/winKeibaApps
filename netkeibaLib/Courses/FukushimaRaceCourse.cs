namespace netkeibaLib.Courses
{
    /// <summary>
    /// 福島競馬場
    /// </summary>
    internal class FukushimaRaceCourse : IRaceCourse
    {
        private static readonly string _name = "福島";
        private static readonly string _uriIdentifer = "03";

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IRaceCourse Create()
            => new FukushimaRaceCourse();

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
        private FukushimaRaceCourse() { }
    }
}
