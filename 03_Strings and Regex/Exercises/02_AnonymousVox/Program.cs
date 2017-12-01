using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class AnonymousVox
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine();
        string valuesString = Console.ReadLine();
        string[] values = valuesString.Split(new char[] { '{', '}' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

        string pattern = @"([A-Za-z]+)(.+)(\1)";
        
        RegexOptions options = RegexOptions.Multiline;

        var matches = Regex.Matches(text, pattern, options);

        int counter = 0;
        foreach (Match m in matches)
        {
            string newValue = m.Groups[1] + values[counter++] + m.Groups[3];
            text = text.Replace(m.Value, newValue);
        }

        Console.WriteLine(text);
    }
}

