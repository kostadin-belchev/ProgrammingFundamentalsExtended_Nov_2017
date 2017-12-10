using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


class Raincast
{
    static void Main(string[] args)
    {
        var typeFound = false;
        var sourceFound = false;
        var forecastFound = false;

        var type = string.Empty;
        var source = string.Empty;
        var forecast = string.Empty;

        while (true)
        {
            string inputLine = Console.ReadLine();

            if (inputLine == "Davai Emo")
                break;
            RegexOptions options = RegexOptions.Multiline;
            string pattern1 = @"^(Type: )(Normal|Warning|Danger)$";
            var matches1 = Regex.Matches(inputLine, pattern1, options);
            string pattern2 = @"^(Source: )(\w+)$";
            var matches2 = Regex.Matches(inputLine, pattern2, options);
            string pattern3 = @"^(Forecast: )([^.,!?\n]*)$";
            var matches3 = Regex.Matches(inputLine, pattern3, options);

            if (!typeFound && matches1.Count > 0)
                foreach (Match m in matches1)
                {
                    type = m.Groups[2].Value;
                    typeFound = true;
                }
            if (!sourceFound && typeFound && matches2.Count > 0)
                foreach (Match m in matches2)
                {
                    source = m.Groups[2].Value;
                    sourceFound = true;
                }
            if (!forecastFound && sourceFound && matches3.Count > 0)
                foreach (Match m in matches3)
                {
                    forecast = m.Groups[2].Value;
                    forecastFound = true;
                }
            if (typeFound && sourceFound && forecastFound)
            {
                Console.WriteLine($"({type}) {forecast} ~ {source}");
                typeFound = false;
                sourceFound = false;
                forecastFound = false;
            }
        }
    }
}

