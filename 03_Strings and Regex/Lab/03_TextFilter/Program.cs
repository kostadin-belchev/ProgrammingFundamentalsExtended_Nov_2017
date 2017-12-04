using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class TextFilter
{
    static void Main(string[] args)
    {
        string[] bannedWords = Console.ReadLine().Split(", ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
        string text = Console.ReadLine();

        foreach (var word in bannedWords)
        {
            text = text.Replace(word, new string('*', word.Length));
        }

        Console.WriteLine(text);
    }
}

