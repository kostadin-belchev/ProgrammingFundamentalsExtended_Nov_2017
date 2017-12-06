using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;



class AnonymousCache
{
    static void Main(string[] args)
    {
        Dictionary<string, Dictionary<string, long>> data = new Dictionary<string, Dictionary<string, long>>();
        Dictionary<string, Dictionary<string, long>> cache = new Dictionary<string, Dictionary<string, long>>();

        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "thetinggoesskrra")
                break;

            string[] inputLineTokens = inputLine.Split(new char[] { ' ', '-', '>', '|' }, StringSplitOptions.RemoveEmptyEntries).ToArray();

            if (inputLineTokens.Length == 1)
            {    //if we receive first type of inputline
                var currentDataSetName = inputLineTokens[0];
                if (cache.ContainsKey(currentDataSetName)) //if the chache contains the dataSet we add it to data
                {
                    data[currentDataSetName] = new Dictionary<string, long>(cache[currentDataSetName]);
                    cache.Remove(currentDataSetName);
                }
                else //if the cache does not have the dataSet we create it
                {
                    data[currentDataSetName] = new Dictionary<string, long>();
                }
            }
            else //if we receive second type of inputline
            {
                var currentDataKey = inputLineTokens[0];
                var currentDataSize = long.Parse(inputLineTokens[1]);
                var currentDataSetName = inputLineTokens[2];

                if (!data.ContainsKey(currentDataSetName))//if the data does not contain the current dataSet we add it to cache
                {
                    if (!cache.ContainsKey(currentDataSetName))
                    {
                        cache[currentDataSetName] = new Dictionary<string, long>();
                    }
                    cache[currentDataSetName][currentDataKey] = currentDataSize;
                }
                else//if the dataSet exists we add the dataKey and dataSize to the current dataSet
                {
                    data[currentDataSetName][currentDataKey] = currentDataSize;
                }

            }
        }

        if (data.Count > 0)
        {
            var result = data.OrderByDescending(x => x.Value.Values.Sum()).First();

            Console.WriteLine($"Data Set: {result.Key}, Total Size: {result.Value.Sum(d => d.Value)}");
            foreach (var dataKey in result.Value)
            {
                Console.WriteLine("$." + dataKey.Key);
            }
        }
    }
}