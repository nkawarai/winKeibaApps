namespace netkeibaLib.Courses
{
    /// <summary>
    /// 中山競馬場
    /// </summary>
    internal class NakayamaRaceCourse : IRaceCourse
    {
        private static readonly string _name = "中山";
        private static readonly string _uriIdentifer = "06";

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IRaceCourse Create()
            => new NakayamaRaceCourse();

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
        private NakayamaRaceCourse() { }

    }
}
