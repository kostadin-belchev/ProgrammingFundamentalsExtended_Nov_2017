using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Icarus
{
    static void Main(string[] args)
    {
        int[] plane = Console.ReadLine().Split().Select(int.Parse).ToArray();

        int initialDamage = 1;
        int currentDamage = initialDamage;

        int initialIndex = int.Parse(Console.ReadLine());
        int currentIndex = initialIndex;
        int indexLeft = initialIndex;

        while (true)
        {
            string command = Console.ReadLine();
            if (command == "Supernova")
                break;

            string[] commandTokens = command.Split();
            string direction = commandTokens[0];
            int steps = int.Parse(commandTokens[1]);

            if (direction == "left")
            {
                currentIndex = indexLeft;
                int counter = 0;
                for (int i = currentIndex - 1; counter < steps; i--)
                {
                    if (i < 0)
                    {
                        i = plane.Length - 1;
                        currentDamage++;
                    }
                    plane[i] = plane[i] - currentDamage;
                    counter++;
                    indexLeft = i;
                }
            }
            else if (direction == "right")
            {
                currentIndex = indexLeft;
                int counter = 0;
                for (int i = currentIndex + 1; counter < steps; i++)
                {
                    if (i > plane.Length - 1)
                    {
                        i = 0;
                        currentDamage++;
                    }
                    plane[i] = plane[i] - currentDamage;
                    counter++;
                    indexLeft = i;
                }
            }
        }
        Console.WriteLine(string.Join(" ", plane));
    }
}

