using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PokeMon
{
    static void Main(string[] args)
    {
        //input
        int N = int.Parse(Console.ReadLine());
        int M = int.Parse(Console.ReadLine());
        int Y = int.Parse(Console.ReadLine());
        //program
        int initialValueOfN = N;
        int pokes = 0;

        while (N >= M)
        {
            N = N - M;
            pokes++;
            if (N == initialValueOfN/2 && Y > 0) //&& Y>0, input could be 0, you cannot devide by 0 thus you get a runtime error
            {
                N =  N / Y;
            }
        }
        //output
        Console.WriteLine(N);
        Console.WriteLine(pokes);
    }
}

