using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class HornetArmada
{
    static void Main(string[] args)
    {
        Dictionary<string, long> legionsAndActivities = new Dictionary<string, long>();
        Dictionary<string, Dictionary<string, long>> legionsAndSoldiers = new Dictionary<string, Dictionary<string, long>>();

        int N = int.Parse(Console.ReadLine());

        for (int i = 0; i < N; i++)
        {
            string inputLine = Console.ReadLine();
            string[] inputLineTokens = inputLine.Split(new char[] { '=', '-', '>', ':', ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            long lastActivity = long.Parse(inputLineTokens[0]);
            string legionName = inputLineTokens[1];
            string soldierType = inputLineTokens[2];
            long soldierCount = long.Parse(inputLineTokens[3]);

            if (legionsAndActivities.ContainsKey(legionName))
            {
                legionsAndActivities.Add(legionName, lastActivity);
                legionsAndSoldiers.Add(legionName, new Dictionary<string, long>());
            }
            

        }
    }
}

