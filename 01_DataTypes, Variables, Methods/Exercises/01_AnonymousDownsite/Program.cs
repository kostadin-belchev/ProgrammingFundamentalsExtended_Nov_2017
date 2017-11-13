using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;


class AnonymousDownsite
{
    static void Main()
    {
        int n = int.Parse(Console.ReadLine());
        long securityKey = long.Parse(Console.ReadLine());
        List<string> listOfSites = new List<string>();
        var totalLoss = 0m;

        for (int i = 0; i < n; i++)
        {
            string inputLine = Console.ReadLine();
            string[] inputLineTokens = inputLine.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
            string siteName = inputLineTokens[0];
            long siteVisits = long.Parse(inputLineTokens[1]);
            decimal siteCommercialPricePerVisit = decimal.Parse(inputLineTokens[2]);

            var siteLoss = siteVisits * siteCommercialPricePerVisit;
            totalLoss += siteLoss;

            listOfSites.Add(siteName);
        }

        BigInteger securityToken = RaiseToPower(securityKey, listOfSites.Count);

        //output
        //Console.WriteLine(string.Join(Environment.NewLine, listOfSites));
        foreach (var item in listOfSites)
        {
            Console.WriteLine(item);
        }
        Console.WriteLine($"Total Loss: {totalLoss:F20}");
        Console.WriteLine($"Security Token: {securityToken}");
    }

    private static BigInteger RaiseToPower(long n, int pow)
    {
        BigInteger numberToPower = 1;

        for (int i = 0; i < pow; i++)
        {
            numberToPower = numberToPower * n;
        }
        return numberToPower;
    }

}