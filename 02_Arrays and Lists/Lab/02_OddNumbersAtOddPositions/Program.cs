using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class OddNumbersAtOddPositions
{
    static void Main(string[] args)
    {
        int[] array = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();

        for (int i = 1; i < array.Length; i+=2)
        {
            if (array[i] % 2 != 0)
            {
                Console.WriteLine($"Index {i} -> {array[i]}");
            }
        }
    }
}
