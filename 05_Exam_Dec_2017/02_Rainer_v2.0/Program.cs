using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rainer_v2
{
    static void Main(string[] args)
    {
        //input
        string inputLine = Console.ReadLine();
        int[] inputLineTokens = inputLine.Split().Select(int.Parse).ToArray();
        int initialIndex = inputLineTokens.Last();
        var nextIndex = 0;
        var index = initialIndex;
        bool isDead = false;
        int steps = 0;
        List<int> sequence = new List<int>(inputLineTokens);
        sequence.RemoveAt(sequence.Count - 1);
        List<int> sequenceCopy = new List<int>(sequence);
        //program
        while (!isDead)
        {
            nextIndex = int.Parse(Console.ReadLine());
            for (int i = 0; i < sequence.Count; i++)
            {
                sequence[i]--;
            }

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] <= 0 && index == nextIndex && !isDead)
                {
                    isDead = true;
                }
                else if (sequence[i] <= 0 && index != nextIndex && !isDead)
                {
                    sequence[i] = sequenceCopy[i];
                }
            }
            index = nextIndex;
        }
        //output
        Console.WriteLine(string.Join(" ", sequence));
        Console.WriteLine(steps - 1);
    }   
}
