using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class MatchDates
{
    static void Main(string[] args)
    {
        string pattern = @"\b(?<day>\d{2})([\-\.\/])(?<month>[A-Z][a-z]{2})\1(?<year>\d{4})\b";
        string input = Console.ReadLine();

        RegexOptions options = RegexOptions.Multiline;
        MatchCollection matchedDates = Regex.Matches(input, pattern, options);

        foreach (Match date in matchedDates)
        {
            var day = date.Groups["day"].Value;
            var month = date.Groups["month"].Value;
            var year = date.Groups["year"].Value;
            Console.WriteLine($"Day: {day}, Month: {month}, Year: {year}");
        }
    }
}

