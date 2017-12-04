using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class MatchHexadecimalNumbers
{
    static void Main(string[] args)
    {
        
        string pattern = @"\b(?:0x)?[0-9A-F]+\b";
        
        string input = Console.ReadLine();
        RegexOptions options = RegexOptions.Multiline;
        List<string> hexadecimalNumbers = new List<string>();

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            hexadecimalNumbers.Add(m.Value);
        }

        Console.WriteLine(string.Join(" ", hexadecimalNumbers));
    }
}

