using System;
using System.Text.RegularExpressions;

namespace _01.MatchFullName
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string regex = @"\b[A-Z][a-z]+ [A-Z][a-z]+\b";

            MatchCollection matches = Regex.Matches(input, regex);
            foreach (Match match in matches)
            {
                Console.Write($"{match.Value} ");
            }
            Console.WriteLine();
        }
    }
}
