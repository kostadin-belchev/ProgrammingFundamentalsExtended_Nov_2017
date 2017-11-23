using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class PokemonDon_tGo
{
    static void Main(string[] args)
    {
        List<int> listOfLongs = Console.ReadLine().Split(new char[] { ' ', '\t' }, StringSplitOptions.RemoveEmptyEntries).Select(int.Parse).ToList();

        List<int> removedElements = new List<int>();

        while (listOfLongs.Count > 0)
        {
            var indexToBeRemoved = int.Parse(Console.ReadLine());
            var elementToBeRemoved = 0;
            if (indexToBeRemoved < 0)
            {
                indexToBeRemoved = 0;
                elementToBeRemoved = listOfLongs[indexToBeRemoved];
                removedElements.Add(elementToBeRemoved);
                listOfLongs[0] = listOfLongs[listOfLongs.Count - 1]; //last element is copied to pisition 0
            }
            else if (indexToBeRemoved > listOfLongs.Count - 1)
            {
                indexToBeRemoved = listOfLongs.Count - 1;
                elementToBeRemoved = listOfLongs[indexToBeRemoved];
                removedElements.Add(elementToBeRemoved);
                listOfLongs[listOfLongs.Count - 1] = listOfLongs[0]; //fist element is copied to last pisition
            }
            else
            {
                elementToBeRemoved = listOfLongs[indexToBeRemoved];
                removedElements.Add(elementToBeRemoved);
                listOfLongs.RemoveAt(indexToBeRemoved);
            }

            for (int i = 0; i < listOfLongs.Count; i++)
            {
                if (listOfLongs[i] <= elementToBeRemoved)
                    listOfLongs[i] += elementToBeRemoved;
                else
                    listOfLongs[i] -= elementToBeRemoved;
            }
        }
        Console.WriteLine(removedElements.Sum());
    }
}

