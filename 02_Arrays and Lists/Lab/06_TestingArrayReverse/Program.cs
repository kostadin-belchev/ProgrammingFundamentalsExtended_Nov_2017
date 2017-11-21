using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class TestingArrayReverse
{
    static void Main(string[] args)
    {
        var n = int.Parse(Console.ReadLine());

        string[] s = new string[n];
        for (int i = 0; i < n; i++)
        {
            s[i] = Console.ReadLine();
        }

        //s[1] = "ttttttttttt";

        Console.WriteLine("Reversed array of string: " + string.Join(" ", ReverseAnArray(s)));
    }

    private static string[] ReverseAnArray(string[] s)
    {
        for (int i = 0; i < s.Length / 2; i++)
        {
            var element = s[i];
            s[i] = s[s.Length - i - 1];
            s[s.Length - i - 1] = element;
        }
        return s;
    }
}
