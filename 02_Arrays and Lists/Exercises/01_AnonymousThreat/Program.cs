using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_AnonymousThreat
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> listOfStrings = Console.ReadLine().Split(' ').ToList();

            while (true)
            {
                string inputLine = Console.ReadLine();
                if (inputLine == "3:1")
                {
                    break;
                }

                string[] inputLineTokens = inputLine.Split(' ').ToArray();
                string command = inputLineTokens[0];

                switch (command)
                {
                    case "merge":
                        int startIndex = int.Parse(inputLineTokens[1]);
                        int endIndex = int.Parse(inputLineTokens[2]);
                        Merge(startIndex, endIndex, listOfStrings);
                        break;
                    case "divide":
                        int index = int.Parse(inputLineTokens[1]);
                        int partitions = int.Parse(inputLineTokens[2]);
                        Divide(index, partitions, listOfStrings);
                        break;
                    default:
                        break;
                }
            }
            //output
            Console.WriteLine(string.Join(" ", listOfStrings));
        }

        private static void Divide(int index, int partitions, List<string> listOfStrings)
        {
            if (partitions != 0)
            {
                string stringToDivide = listOfStrings[index];
                StringBuilder builder = new StringBuilder(stringToDivide);


            }
        }

        private static void Merge(int startIndex, int endIndex, List<string> listOfStrings)
        {
            if (startIndex < 0)
                startIndex = 0;
            if (endIndex < 0)
            {
                endIndex = 0;
                startIndex = 0;
            }
                
            if (endIndex >= listOfStrings.Count)
                endIndex = listOfStrings.Count - 1;
            if (startIndex > listOfStrings.Count - 1)
                startIndex = 0;

            //if (startIndex < 0)
            //    startIndex = 0;
            //else if (startIndex > listOfStrings.Count - 1)
            //{
            //    startIndex = 0;
            //    endIndex = 0;
            //}

            //if (endIndex > listOfStrings.Count - 1)
            //    endIndex = listOfStrings.Count - 1;
            //else if (endIndex < 0)
            //{
            //    startIndex = 0;
            //    endIndex = 0;
            //}

            string stringToBeAdded = string.Empty;

            for (int i = startIndex; i <= endIndex; i++)
                stringToBeAdded += listOfStrings[i];

            listOfStrings.RemoveRange(startIndex, endIndex - startIndex + 1);
            listOfStrings.Insert(startIndex, stringToBeAdded);
        }
    }
}
