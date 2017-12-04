using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class MatchFullName
{
    static void Main(string[] args)
    {
        string pattern = @"\b[A-Z][a-z]+\ [A-Z][a-z]+\b";
        string input = Console.ReadLine();

        RegexOptions options = RegexOptions.Multiline;

        var matchedNames = Regex.Matches(input, pattern, options);

        //foreach (Match m in Regex.Matches(input, pattern, options))
            //Console.WriteLine("'{0}' found at index {1}.", m.Value, m.Index);

        foreach (Match m in matchedNames)
        {
            Console.Write(m.Value + " ");
        }

        Console.WriteLine();
    }
}

