using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class SortNumbers
{
    static void Main(string[] args)
    {
        List<decimal> listOfDecimals = Console.ReadLine().Split(' ').Select(decimal.Parse).ToList();
        listOfDecimals.Sort();
        Console.WriteLine(string.Join(" <= ", listOfDecimals));
    }
}

