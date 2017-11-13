using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HornetWings
{
    static void Main(string[] args)
    {
        long wingFlaps = long.Parse(Console.ReadLine());
        decimal metersFor1000Flaps = decimal.Parse(Console.ReadLine());
        long induranceP = long.Parse(Console.ReadLine());

        decimal metersTraveled = (wingFlaps / 1000) * metersFor1000Flaps;
        decimal flappingTime = wingFlaps / 100;
        decimal restTime = (wingFlaps / induranceP) * 5;
        decimal secondsPassed = flappingTime + restTime;

        Console.WriteLine($"{metersTraveled:F2} m.");
        Console.WriteLine($"{secondsPassed} s.");
    }
}

