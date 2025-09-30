using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bitte geben Sie eine Zahl ein.");
            string anzTageInput = Console.ReadLine();
            int anzTage = 0;

            if (int.TryParse(anzTageInput, out anzTage) == true && anzTage > 27 && anzTage < 32)
            {
                Console.WriteLine("Ein Monat mit " + anzTage + "hat " + (anzTage * 86400) + " Sekunden");
            }
            else
            {
                Console.WriteLine("Eingabefehler. Bitte geben Sie eine ganze Zahl zwischen 28 und 31 ein.");
            }
            Console.ReadKey();
        }
    }
}
