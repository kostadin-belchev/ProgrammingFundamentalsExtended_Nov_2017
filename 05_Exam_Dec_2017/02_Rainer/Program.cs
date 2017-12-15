using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rainer
{
    static void Main(string[] args)
    {
        //input
        string inputLine = Console.ReadLine();
        int[] inputLineTokens = inputLine.Split().Select(int.Parse).ToArray();
        int initialIndex = inputLineTokens.Last();
        int donaldIndex = initialIndex;
        var index = 0;
        bool isDead = false;
        int steps = 0;
        List<int> sequence = new List<int>(inputLineTokens);
        sequence.RemoveAt(sequence.Count - 1);
        List<int> sequenceCopy = new List<int>(sequence);
        //program
        while (!isDead)
        {
            for (int i = 0; i < sequence.Count; i++)
            {

                sequence[i]--;
                
                if (sequence[i] == 0  && !isDead)//&& donaldIndex != i
                {
                    sequence[i] = sequenceCopy[i];
                }
                else if (sequence[i] == 0 && donaldIndex == i && !isDead)
                {
                    isDead = true;
                }
            }
            steps++;
            if (isDead)
            {
                break;
            }
            index = donaldIndex;
            donaldIndex = int.Parse(Console.ReadLine());
        }
        //output
        Console.WriteLine(string.Join(" ", sequence));
        Console.WriteLine(steps - 1);
    }
}

