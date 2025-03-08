namespace netkeibaLib.Courses
{
    /// <summary>
    /// 競馬場インターフェイス
    /// </summary>
    internal interface IRaceCourse
    {
        /// <summary>
        /// 2文字通称名
        /// </summary>
        public string TwoLetterCode { get; }

        /// <summary>
        /// URIに用いる識別子
        /// </summary>
        public string UriIdentifer { get; }
    }
}
