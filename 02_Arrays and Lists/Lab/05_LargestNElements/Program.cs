using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargestNElements
{
    static void Main(string[] args)
    {
        List<int> listOfInts = Console.ReadLine().Split(' ').Select(int.Parse).ToList();
        int n = int.Parse(Console.ReadLine());
        listOfInts = listOfInts.OrderByDescending(x => x).ToList();
        List<int> resultList = new List<int>();

        for (int i = 0; i < n; i++)
        {
            resultList.Add(listOfInts[i]);
        }

        Console.WriteLine(string.Join(" ", resultList));
    }
}

