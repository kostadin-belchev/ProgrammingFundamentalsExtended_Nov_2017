using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class RotateArrayofStrings
{
    static void Main()
    {
        string[] array = Console.ReadLine().Split(' ');

        var rotatedArray = new string[array.Length];

        for (int i = 1; i < array.Length; i++)
        {
            var element = array[array.Length - 1];

            rotatedArray[i] = array[i - 1];
            rotatedArray[0] = element;
        }

        Console.WriteLine(string.Join(" ", rotatedArray));
    }
}
