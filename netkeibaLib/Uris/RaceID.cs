using netkeibaLib.Courses;
using netkeibaLib.General;

namespace netkeibaLib.Uris
{
    internal class RaceID
    {
        private string _id;

        /// <summary>
        /// コンストラクタ
        /// </summary>
        public RaceID(IRaceCourse raceCourse, IYear year, IKaisaiInfo kaisaiInfo, IRaceNumber raceNumber)
        {
            _id = $"{year}{raceCourse.TwoLetterCode}{kaisaiInfo.TwoLetterSeriesCode()}{kaisaiInfo.TwoLetterDayCode()}{raceNumber.TwoLetterCode()}";
        }

        public override string ToString() => _id;
    }
}
