using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class RainAir
{
    static void Main(string[] args)
    {
        Dictionary<string, List<int>> customerFlights = new Dictionary<string, List<int>>();

        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "I believe I can fly!")
            {
                break;
            }
            string[] inputLineTokens = inputLine.Split("= ".ToCharArray(), StringSplitOptions.RemoveEmptyEntries).ToArray();
            List<int> customerFlightList = new List<int>();
            string customerName = string.Empty;

            if (inputLineTokens.Length == 2)
            {
                customerName = inputLineTokens[0];
                var customerFlightNumber = 0;
                try
                {
                    customerFlightNumber = int.Parse(inputLineTokens[1]);
                    customerFlightList.Add(customerFlightNumber);
                }
                catch
                {
                    string customer2Name = inputLineTokens[1];
                    customerFlights[customerName] = customerFlights[customer2Name];
                }
            }
            else
            {
                customerName = inputLineTokens[0];
                var listToAdd = inputLineTokens.Skip(1).Select(int.Parse).ToList();
                customerFlightList.AddRange(listToAdd);
            }

            if (!customerFlights.ContainsKey(customerName)) //if customerName does not exist we add it with his flights
            {
                customerFlights[customerName] = customerFlightList;
                //ERROR IS HERE, you have to foreach the list and fill it manually!!! Lists are ference type of data
            }
            else
            {
                customerFlights[customerName].AddRange(customerFlightList);
            }
            
        }
        //output
        //ordering
        foreach (var item in customerFlights.Values)
        {
            item.Sort();
        }
        customerFlights = customerFlights.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key).ToDictionary(x => x.Key, y => y.Value);
        //printing
        foreach (var keyValuePair in customerFlights)
        {
            Console.WriteLine($"#{keyValuePair.Key} ::: {string.Join(", ", keyValuePair.Value)}");
        }
    }
}

