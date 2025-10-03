using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DateTime today = DateTime.Today;
            DateTime birthday;
            Console.Write("Gib deinen Geburtstag ein (TT.MM.JJJJ): ");
            string input = Console.ReadLine();
            if (!DateTime.TryParse(input, out birthday))
            {
                Console.WriteLine("Ungültiges Datum!");
                return;
            }
            TimeSpan daysOld = today - birthday;
            int yearsOld = (int)Math.Floor(daysOld.TotalDays / 365.25);
            Console.WriteLine("Alter in Jahren: " + yearsOld.ToString("0"));
            int monthsOld = (int)Math.Floor(daysOld.TotalDays / 30.4375);
            Console.WriteLine("Alter in Monaten: " + monthsOld.ToString("0"));
            int weeksOld = (int)Math.Floor(daysOld.TotalDays / 7);
            Console.WriteLine("Alter in Wochen: " + weeksOld.ToString("0"));
            Console.WriteLine("Alter in Tagen: " + daysOld.TotalDays.ToString("0"));

        }
    }
}
