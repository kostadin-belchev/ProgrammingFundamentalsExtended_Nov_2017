using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Raindrops
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());
        decimal density = decimal.Parse(Console.ReadLine());
        var sumOfAllRegionalCoefficients = 0m;
        var result = 0m;
        for (int i = 1; i <= n; i++)
        {
            string[] regionInfo = Console.ReadLine().Split().ToArray();
            long raindropsCount = long.Parse(regionInfo[0]);
            long squareMeters = long.Parse(regionInfo[1]);
            decimal regionalCoefficient = raindropsCount / (decimal) squareMeters;
            sumOfAllRegionalCoefficients += regionalCoefficient;
        }
        if (density == 0)
        {
            result = sumOfAllRegionalCoefficients;
        }
        else
        {
            result = sumOfAllRegionalCoefficients / density;
        }
        Console.WriteLine($"{result:F3}");
    }
}

