using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Program
{
    static void Main(string[] args)
    {
        //Hospital 28th of August Programming basics, taks 4
        //int days = int.Parse(Console.ReadLine());

        //int treatedPatients = 0;
        //int untreatedPatients = 0;
        //int doctors = 7;

        //for (int i = 1; i <= days; i++)
        //{
        //    int patientsForTheDay = int.Parse(Console.ReadLine());



        //    if (i % 3 == 0 && untreatedPatients > treatedPatients)
        //    {
        //        doctors++;
        //    }

        //    if (patientsForTheDay > doctors)
        //    {
        //        untreatedPatients += patientsForTheDay - doctors;
        //        treatedPatients += doctors;
        //    }
        //    if (patientsForTheDay <= doctors)
        //    {
        //        treatedPatients += patientsForTheDay;
        //    }
        //}

        //Console.WriteLine($"Treated patients: {treatedPatients}.");
        //Console.WriteLine($"Untreated patients: {untreatedPatients}.");
        //trimming PMR texts
        string[] text = File.ReadAllLines(@"textToTrim.txt");
        List<string> trimmedText = new List<string>();
        foreach (var line in text)
        {
            trimmedText.Add(line.Trim());
        }
        File.WriteAllLines(@"trimmedText.txt", trimmedText);
    }
}

