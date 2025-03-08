namespace netkeibaLib.Courses
{
    /// <summary>
    /// 東京競馬場
    /// </summary>
    internal class TokyoRaceCourse : IRaceCourse
    {
        private static readonly string _name = "東京";
        private static readonly string _uriIdentifer = "05";

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IRaceCourse Create()
            => new TokyoRaceCourse();

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
        private TokyoRaceCourse() { }

    }
}
