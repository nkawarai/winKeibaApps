namespace netkeibaLib.Courses
{
    /// <summary>
    /// 中京競馬場
    /// </summary>
    internal class ChukyoRaceCourse : IRaceCourse
    {
        private static readonly string _name = "中京";
        private static readonly string _uriIdentifer = "07";

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IRaceCourse Create()
            => new ChukyoRaceCourse();

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
        private ChukyoRaceCourse() { }
    }
}
