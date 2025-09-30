using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] month = new string[12];
            month[0] = "Januar";
            month[1] = "Februar";
            month[2] = "März";
            month[3] = "Aprill";
            month[4] = "Mai";
            month[5] = "Juni";
            month[6] = "Juli";
            month[7] = "August";
            month[8] = "September";
            month[9] = "Oktober";
            month[10] = "November";
            month[11] = "Dezember";

            Console.Write("Bitte geben Sie eine Zahl zwischen 1 und 12 ein: ");
            string monthInput = Console.ReadLine();
            int monthNumber = 0;
            if (int.TryParse(monthInput, out monthNumber) == true && monthNumber > 0 && monthNumber < 13)
            {
                Console.Write("Monat: "); Console.Write(month[monthNumber-1]);
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine ganze Zahl zwischen 1 und 12 ein.");
            }
            Console.ReadKey();
        }
    }
}
