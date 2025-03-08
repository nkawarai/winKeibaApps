namespace netkeibaLib.Courses
{
    /// <summary>
    /// 京都競馬場
    /// </summary>
    internal class KyotoRaceCourse : IRaceCourse
    {
        private static readonly string _name = "京都";
        private static readonly string _uriIdentifer = "08";

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IRaceCourse Create()
            => new KyotoRaceCourse();

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
        private KyotoRaceCourse() { }

    }
}
