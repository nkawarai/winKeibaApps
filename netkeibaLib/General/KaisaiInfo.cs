namespace netkeibaLib.General
{
    /// <summary>
    /// 開催情報
    /// </summary>
    public interface IKaisaiInfo
    {
        /// <summary>
        /// 開催回文字列
        /// </summary>
        public string TwoLetterSeriesCode();

        /// <summary>
        /// 開催日文字列
        /// </summary>
        public string TwoLetterDayCode();
    }

    internal class KaisaiInfo : IKaisaiInfo
    {
        private int _seriesNumber;
        private int _dayNumber;

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        /// <returns></returns>
        static public IKaisaiInfo Create(int seriesNumber, int dayNumber)
            => new KaisaiInfo(seriesNumber, dayNumber);

        /// <summary>
        /// 開催回文字列
        /// </summary>
        public string TwoLetterSeriesCode()
            => _seriesNumber.ToString("D2");

        /// <summary>
        /// 開催日文字列
        /// </summary>
        public string TwoLetterDayCode()
            => _dayNumber.ToString("D2");

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        private KaisaiInfo(int seriesNumber, int dayNumber)
        {
            if (seriesNumber < 1 || seriesNumber > 7)
            {
                throw new ArgumentOutOfRangeException($"開催回は1～6まで有効です。指定された開催回:{seriesNumber}");
            }
            if (dayNumber < 1 || dayNumber > 15)
            {
                throw new ArgumentOutOfRangeException($"開催日は1～14まで有効です。指定された開催日:{dayNumber}");
            }

            _seriesNumber = seriesNumber;
            _dayNumber = dayNumber;
        }
    }
}
