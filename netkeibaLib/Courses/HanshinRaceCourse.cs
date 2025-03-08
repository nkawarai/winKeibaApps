namespace netkeibaLib.Courses
{
    /// <summary>
    /// 阪神競馬場
    /// </summary>
    internal class HanshinRaceCourse : IRaceCourse
    {
        private static readonly string _name = "阪神";
        private static readonly string _uriIdentifer = "09";

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IRaceCourse Create()
            => new HanshinRaceCourse();

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
        private HanshinRaceCourse() { }
    }
}
