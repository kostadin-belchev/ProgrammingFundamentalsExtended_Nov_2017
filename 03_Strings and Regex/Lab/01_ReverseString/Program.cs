using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class ReverseString
{
    static void Main(string[] args)
    {
        //string s = Console.ReadLine();

        //char[] charArray = s.ToCharArray();

        //var reversedString = string.Empty;

        //for (int i = s.Length - 1; i >= 0; i--)
        //{
        //    reversedString += charArray[i];
        //}

        //Console.WriteLine(string.Join(string.Empty, reversedString));

        string s = Console.ReadLine();

        Console.WriteLine(Reverse(s));
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

