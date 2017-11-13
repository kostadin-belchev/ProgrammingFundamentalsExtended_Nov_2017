using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Resurrection
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            long totalLength = long.Parse(Console.ReadLine());
            decimal totalWidth = decimal.Parse(Console.ReadLine());
            int wingLength = int.Parse(Console.ReadLine());

            decimal totalYears = (totalLength * totalLength ) * (totalWidth + 2 * wingLength);
            Console.WriteLine(totalYears);
        }
    }
}

