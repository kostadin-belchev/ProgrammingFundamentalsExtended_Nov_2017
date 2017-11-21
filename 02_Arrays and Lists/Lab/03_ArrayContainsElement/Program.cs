using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ArrayContainsElement
{
    static void Main(string[] args)
    {
        int[] listOfInts = Console.ReadLine().Split(' ').Select(int.Parse).ToArray();
        int n = int.Parse(Console.ReadLine());
        bool isFound = false;

        for (int i = 0; i < listOfInts.Length; i++)
        {
            if (listOfInts[i] == n)
                isFound = true;
        }

        if (isFound)
            Console.WriteLine("yes");
        else
            Console.WriteLine("no");

        //or using Contains()
        //if (listOfInts.Contains(n))
            //Console.WriteLine("yes");
        //else
            //Console.WriteLine("no");
    }
}

