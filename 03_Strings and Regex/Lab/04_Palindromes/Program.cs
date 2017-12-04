using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Palindromes
{
    static void Main(string[] args)
    {
        string[] input = Console.ReadLine().Split(" ,.?!".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
        List<string> palindromes = new List<string>();

        foreach (var word in input)
        {
            if (IsPalindrome(word))
            {
                palindromes.Add(word);
            }
        }
        palindromes = palindromes.Distinct().ToList();
        palindromes.Sort();
        Console.WriteLine(string.Join(", ", palindromes));
    }

    private static bool IsPalindrome(string word)
    {
        string first = word.Substring(0, word.Length / 2);
        char[] arr = word.ToCharArray();
        Array.Reverse(arr);
        string temp = new string(arr);
        string second = temp.Substring(0, temp.Length / 2);
        return first.Equals(second);
    }
}

