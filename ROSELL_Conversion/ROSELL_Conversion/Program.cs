using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROSELL_Conversion
{
    internal class Conversion

    {
        static void Main(string[] args)
        {
             

        Console.Write("Enter length (in centimeters) >>>");
        double lengthInCm = double.Parse(Console.ReadLine());

        double lengthInInches = Math.Round(lengthInCm / 2.54);
        int yards = (int)(lengthInInches / 36);
        lengthInInches -= yards * 36;
        int feet = (int)(lengthInInches / 12);
        lengthInInches -= feet * 12;
        int inches = (int)lengthInInches;

        Console.WriteLine($"{yards} yards, {feet} feet{(feet == 1 ? "" : "s")}, {inches} inches");
        }
    }
}
