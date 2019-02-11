 using System;
using System.Text.RegularExpressions;
using System.Collections.Generic;
using System.Linq;

namespace _02.MatchPhoneNumber
{
    class MatchPhoneNumbers
    {
        static void Main(string[] args)
        {
            string number = Console.ReadLine();
            string regex = @"\+[359]+( |-)2\1\d{3}\1\d{4}\b";

            MatchCollection matches = Regex.Matches(number, regex);

            var matchedPhones = matches
               .Cast<Match>()
                .Select(a => a.Value.Trim())
                .ToArray();
            Console.WriteLine(string.Join(", ",matchedPhones));
        }
    }
}

