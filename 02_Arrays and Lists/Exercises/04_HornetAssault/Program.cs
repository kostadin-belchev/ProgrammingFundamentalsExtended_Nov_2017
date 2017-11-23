using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HornetAssault
{
    static void Main(string[] args)
    {
        var beehives = Console.ReadLine().Split().Select(long.Parse).ToList();
        var hornets = Console.ReadLine().Split().Select(long.Parse).ToList();

        long summedHornetPower = 0;

        for (int i = 0; i < hornets.Count; i++)
        {
            summedHornetPower += hornets[i];
        }

        for (int i = 0; i < beehives.Count; i++)
        {
            if (beehives[i] < summedHornetPower)
            {
                beehives[i] = 0;
            }
            else if (beehives[i] >= summedHornetPower)
            {
                beehives[i] -= summedHornetPower;
                summedHornetPower -= hornets.First();
                hornets.Remove(hornets.First());
            }

            if (hornets.Count == 0) //resolved the 80/100
            {
                break;
            }
        }
        //output
        var aliveBeehives = new List<long>();

        for (int i = 0; i < beehives.Count; i++)
        {
            if (beehives[i] != 0)
            {
                aliveBeehives.Add(beehives[i]);
            }
        }

        if (aliveBeehives.Count > 0)
            Console.WriteLine(string.Join(" ", aliveBeehives));
        else
            Console.WriteLine(string.Join(" ", hornets));
        
    }
}

