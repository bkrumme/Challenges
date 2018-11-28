namespace Challenges
{
    public static class Exercism
    {
        public static bool IsLeapYear(int year)
        {
            bool isLeapYear = year % 4 == 0;
            var divisibleBy100 = year % 100 == 0;
            if (!divisibleBy100)
            {
                return isLeapYear;
            }
            return year % 400 == 0;
        }
    }
}
