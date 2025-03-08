namespace netkeibaLib.General
{
    public interface IYear
    {
        
    }

    internal class Year : IYear
    {
        private readonly int MIN_VALUE = 1990; //TODO とりあえず仮
        private readonly int MAX_VALUE = 2100;
        private readonly int _value;

        /// <summary>
        /// Factoryメソッド
        /// </summary>
        static public IYear Create(int year)
            => new Year(year);

        public override string ToString()
        {
            return _value.ToString();
        }

        /// <summary>
        /// 隠蔽コンストラクタ
        /// </summary>
        /// <param name="value"></param>
        /// <exception cref="ArgumentOutOfRangeException"></exception>
        private Year(int value)
        {
            if (value < MIN_VALUE || MAX_VALUE < value)
            {
                throw new ArgumentOutOfRangeException("指定された年が不正です。");
            }
            _value = value;
        }
    }
}
