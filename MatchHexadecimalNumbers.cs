using System;
using System.Text.RegularExpressions;
using System.Linq;

namespace _03.MatchHexadecimalNumbers
{
    class MatchHexadecimalNumbers
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string pattern = @"\b(0x)?[0-9A-F]+\b";

            var matchedHexadecimals = Regex.Matches(input, pattern)
                .Cast<Match>()
                .Select(a => a.Value)
                .ToArray();

            Console.WriteLine(string.Join(" ",matchedHexadecimals));
        }
    }
}
