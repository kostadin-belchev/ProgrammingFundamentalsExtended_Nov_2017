using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class MatchPhoneNumber
{
    static void Main(string[] args)
    {
        string pattern = @"(^|\ )\+359(\ |\-)2(\2)\d{3}(\2)\d{4}\b";
        string input = Console.ReadLine();
        RegexOptions options = RegexOptions.Multiline;

        var matches = Regex.Matches(input, pattern, options);

        var matchedPhones = matches.Cast<Match>().Select(x => x.Value.Trim()).ToArray();

        Console.WriteLine(string.Join(", ", matchedPhones));
    }
}

