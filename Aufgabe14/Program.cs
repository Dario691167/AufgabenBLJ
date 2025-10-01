using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe14
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.Write("Eingabe Jahr (q to quit): ");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    quit = true;
                }
                else
                {
                    if (int.TryParse(input, out int year))
                    {
                        if (DateTime.IsLeapYear(year))
                        {
                            Console.WriteLine($"{year} ist ein Schaltjahr.");
                        }
                        else
                        {
                            Console.WriteLine($"{year} ist kein Schaltjahr.");
                        }
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl oder 'q' eingeben.");
                    }
                }
            }
        }
    }
}
