using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class CountSubstringOccurrences
{
    static void Main(string[] args)
    {
        string text = Console.ReadLine().ToLower();
        string pattern = Console.ReadLine().ToLower();
        int counter = 0;
        int index = text.IndexOf(pattern);

        //for (int i = 0; i < text.Length - pattern.Length + 1; i++)
        //if (text.Substring(i, pattern.Length) == pattern)
        //counter++;    

        while (index != -1)
        {
            counter++;
            index = text.IndexOf(pattern, index + 1);
        }
        

        Console.WriteLine(counter);
    }
}

