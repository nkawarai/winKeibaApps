namespace netkeibaLib.Uris
{
    /// <summary>
    /// レース結果ページ
    /// </summary>
    internal class RaceResultUri : IRaceResultUri
    {
        private readonly Uri _uri;

        /// <summary>
        /// URIを取得する
        /// </summary>
        /// <returns></returns>
        public Uri GetUri()
            => _uri;

        private RaceResultUri(RaceID raceID)
        {
            _uri = new Uri($"https://race.netkeiba.com/race/result.html?race_id={raceID}");
        }
    }
}
