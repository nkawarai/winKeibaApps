namespace netkeibaLib.Courses
{
    /// <summary>
    /// 函館競馬場
    /// </summary>
    internal class HakodateRaceCourse : IRaceCourse
    {
        private static readonly string _name = "函館";
        private static readonly string _uriIdentifer = "02";

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IRaceCourse Create()
            => new HakodateRaceCourse();

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
        private HakodateRaceCourse() { }

    }
}
