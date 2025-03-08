namespace netkeibaLib.General
{
    public interface IRaceNumber
    {
        string TwoLetterCode();
    }

    internal class RaceNumber : IRaceNumber
    {
        private int _raceNumber;

        /// <summary>
        /// factoryメソッド
        /// </summary>
        static public IRaceNumber Create(int raceNumber)
            => new RaceNumber(raceNumber);

        public string TwoLetterCode()
            => _raceNumber.ToString("D2");

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        private RaceNumber(int raceNumber)
        {
            if (raceNumber < 1 || raceNumber > 12)
            {
                throw new ArgumentOutOfRangeException($"レース番号は1～12が有効です。指定されたレース番号:{raceNumber}");
            }
            _raceNumber = raceNumber;
        }
    }
}
