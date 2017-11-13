using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Wormtest
{
    static void Main(string[] args)
    {
        //input
        int wormLengthInMeters = int.Parse(Console.ReadLine());
        double wormWidthInCentimeters = double.Parse(Console.ReadLine());

        int wormLengthInCentimeters = wormLengthInMeters * 100;

        if (wormLengthInCentimeters % wormWidthInCentimeters == 0 || wormWidthInCentimeters == 0)
        {
            var widthXlength = wormLengthInCentimeters * wormWidthInCentimeters;
            Console.WriteLine($"{widthXlength:F2}");
        }
        else
        {
            var percatage = (wormLengthInCentimeters / wormWidthInCentimeters) * 100;
            Console.WriteLine($"{percatage:F2}%");
        }
        //&& Y>0, input could be 0, you cannot devide by 0 thus you get a runtime error
    }
}

