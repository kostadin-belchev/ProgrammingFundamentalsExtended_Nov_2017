using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class IntegerTypes
{
    static void Main()
    {
        //input
        byte num1 = byte.Parse(Console.ReadLine());
        uint num2 = uint.Parse(Console.ReadLine());
        int num3 = int.Parse(Console.ReadLine());
        long num4 = long.Parse(Console.ReadLine());
        //output
        Console.Write(num1 + " ");
        Console.Write(num2 + " ");
        Console.Write(num3 + " ");
        Console.WriteLine(num4);
    }
}

