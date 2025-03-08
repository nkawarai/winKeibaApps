namespace netkeibaLib.Courses
{
    /// <summary>
    /// 新潟競馬場
    /// </summary>
    internal class NiigataRaceCourse : IRaceCourse
    {
        private static readonly string _name = "新潟";
        private static readonly string _uriIdentifer = "04";

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IRaceCourse Create()
            => new NiigataRaceCourse();

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
        private NiigataRaceCourse() { }
    }
}
