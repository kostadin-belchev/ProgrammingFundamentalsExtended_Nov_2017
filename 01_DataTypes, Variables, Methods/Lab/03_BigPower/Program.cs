using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class BigPower
{
    static void Main(string[] args)
    {
        int n = int.Parse(Console.ReadLine());

        BigInteger num = PoweredByN(n, n);

        Console.WriteLine(num);
    }

    private static BigInteger PoweredByN(int num, int power)
    {
        BigInteger result = 1;

        if (power == 0)
            result = 1;
        else
        {
            for (int i = 1; i <= power; i++)
            {
                result = result * num;
            }
        }
        return result;
    }
}

