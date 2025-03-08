namespace netkeibaLib.Courses
{
    internal static class RaceCourseFactory
    {
        static public IRaceCourse? CreateFromName(string name)
        {
            var courseList = new List<IRaceCourse>()
            {
                SapporoRaceCourse.Create(),
                HakodateRaceCourse.Create(),
                FukushimaRaceCourse.Create(),
                NiigataRaceCourse.Create(),
                TokyoRaceCourse.Create(),
                NakayamaRaceCourse.Create(),
                ChukyoRaceCourse.Create(),
                KyotoRaceCourse.Create(),
                HanshinRaceCourse.Create(),
                KokuraRaceCourse.Create()
            };

            return courseList.Where(x => x.TwoLetterCode == name).FirstOrDefault();
        }
    }
}
