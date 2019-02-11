using System;
using System.Text.RegularExpressions;

namespace _04.MatchDates
{
    class MatchDates
    {
        static void Main(string[] args)
        {
           // string inputDate = Console.ReadLine();
            string regex = @"\b(?<day>\d{2})([.-\/])(?<month>[A-Z][a-z]{2})\2(?<year>\d{4})\b";
            string inputDate = Console.ReadLine();

            MatchCollection matchDates = Regex.Matches(inputDate, regex);
            foreach (Match date in matchDates)
            {
                var day = date.Groups["day"].Value;
                var month = date.Groups["month"].Value;
                var year = date.Groups["year"].Value;

                Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
            }
        }
    }
}
