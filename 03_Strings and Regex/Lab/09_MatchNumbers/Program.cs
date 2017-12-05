using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



class MatchNumbers
{
    static void Main(string[] args)
    {
        string pattern = @"(^|(?<=\s))-?(?:\d+)?(?:\.\d+)?(?=\s|$)";
        string input = Console.ReadLine();

        RegexOptions options = RegexOptions.Multiline;

        foreach (Match m in Regex.Matches(input, pattern, options))
        {
            Console.Write(m.Value + " ");
        }

        Console.WriteLine();
    }
}

