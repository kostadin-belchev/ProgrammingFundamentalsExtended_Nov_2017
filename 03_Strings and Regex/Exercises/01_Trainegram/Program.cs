using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Trainegram
{
    static void Main(string[] args)
    {
        List<string> validTrains = new List<string>();

        while (true)
        {
            string input = Console.ReadLine();
            if (input == "Traincode!")
                break;

            string pattern = @"^(<\[([^A-Za-z0-9\n])*?\]\.)(\.\[([A-Za-z0-9\n])*?\]\.)*?$";
            
            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(input, pattern, options))
            {
                validTrains.Add(m.Value);
            }
        }
        foreach (var item in validTrains)
        {
            Console.WriteLine(item);
        }
    }
}

