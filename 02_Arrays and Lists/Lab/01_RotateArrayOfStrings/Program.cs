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

        //int rotations = int.Parse(Console.ReadLine());

        //for (int j = 0; j < rotations; j++)
        {
            var element = array[array.Length - 1];
            
            for (int i = array.Length - 1; i >= 1; i--)
            {
                array[i] = array[i - 1];
            }
            array[0] = element;
        }

        Console.WriteLine(string.Join(" ", array));
    }
}
