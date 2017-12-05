using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class ReplaceATag
{
    static void Main(string[] args)
    {
        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "end")
                break;

            string pattern = @"<a.*?href.*?=(.*)>(.*?)<\/a>";
            string replacement = @"[URL href=$1]$2[/URL]";
            string replaced = Regex.Replace(inputLine, pattern, replacement);
            Console.WriteLine(replaced);
        }
    }
}

