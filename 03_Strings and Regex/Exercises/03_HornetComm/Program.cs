using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


class HornetComm
{
    static void Main(string[] args)
    {
        List<string> recipients = new List<string>();
        List<string> privateMessages = new List<string>();
        List<string> broadcastMessages = new List<string>();
        List<string> frequencies = new List<string>();

        while (true)
        {
            string inputLine = Console.ReadLine();
            if (inputLine == "Hornet is Green")
                break;

            string[] inputLineTokens = Regex.Split(inputLine, "<->");
            string firstQuery = inputLineTokens[0];
            string secondQuery = inputLineTokens[1];

            string pattern = @"^([0-9]+)\ <->\ ([A-Za-z0-9]+)$";
            string pattern2 = @"^([^0-9]+)\ <->\ ([A-Za-z0-9]+)$";

            RegexOptions options = RegexOptions.Multiline;

            foreach (Match m in Regex.Matches(inputLine, pattern, options))
            {
                var recipientsCode = m.Groups[1].ToString();
                var message = m.Groups[2].ToString();
                
                recipients.Add(Reverse(recipientsCode));
                privateMessages.Add(message);
            }

            foreach (Match m2 in Regex.Matches(inputLine, pattern2, options))
            {
                var message = m2.Groups[1].ToString();
                var frequency = m2.Groups[2].ToString();
                string pattern3 = @"([A-Z])|([a-z])";
                string input3 = frequency;
                RegexOptions options3 = RegexOptions.Multiline;

                foreach (Match m3 in Regex.Matches(input3, pattern3, options3))
                {
                    string newValue1 = m3.Groups[1].Value.ToLower();
                    string newValue2 = m3.Groups[2].Value.ToUpper();
                    if (newValue1.Length > 0)
                        frequency = frequency.Replace(m3.Groups[1].Value, newValue1);
                    if (newValue2.Length > 0)
                        frequency = frequency.Replace(m3.Groups[2].Value, newValue2);
                }
                broadcastMessages.Add(message);
                frequencies.Add(frequency);
            }
        }

        Console.WriteLine("Broadcasts:");
        if (broadcastMessages.Count > 0)
            for (int i = 0; i < broadcastMessages.Count; i++)
                Console.WriteLine($"{frequencies[i]} -> {broadcastMessages[i]}");
        else
            Console.WriteLine("None");

        Console.WriteLine("Messages:");
        if (privateMessages.Count > 0)
            for (int i = 0; i < privateMessages.Count; i++)
                Console.WriteLine($"{recipients[i]} -> {privateMessages[i]}");
        else
            Console.WriteLine("None");
        
    }

    public static string Reverse(string s)
    {
        char[] charArray = s.ToCharArray();
        Array.Reverse(charArray);
        return new string(charArray);
    }
}

