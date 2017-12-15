using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Rainer_v3
{
    static void Main(string[] args)
    {
        string[] inputLineTokens = Console.ReadLine().Split().ToArray();
        List<int> sequence = inputLineTokens.Take(inputLineTokens.Length - 1).Select(int.Parse).ToList();
        var sequenceCopy = new List<int>(sequence);
        var initialIndex = int.Parse(inputLineTokens.Last());
        var isWet = false;
        int currentIndex = initialIndex;
        int steps = 0;

        while (!isWet)
        {

            for (int i = 0; i < sequence.Count; i++)
            {
                sequence[i]--;
            }
            

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == 0 && currentIndex == i)
                {
                    isWet = true;
                    break;
                }
            }

            if (isWet)
                break;

            for (int i = 0; i < sequence.Count; i++)
            {
                if (sequence[i] == 0)
                    sequence[i] = sequenceCopy[i];
            }
            
            currentIndex = int.Parse(Console.ReadLine());
            steps++;
        }
        
        Console.WriteLine(string.Join(" ", sequence));
        Console.WriteLine(steps);
    }
}

