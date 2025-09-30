using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie vieele Kilometer möchtest du rennen?");
            string kmInput = Console.ReadLine();
            if (int.TryParse(kmInput, out int anzKm) == true && anzKm < 42)
            {
                int anzRunden = (anzKm * 1000) / 400;
                Console.WriteLine("Das sind " + (anzRunden) + " Runden. Bereit für den Lauft? (Ja/Nein)");
                string bereitInput = Console.ReadLine();
                if (bereitInput == "Ja")
                {
                    int i = 1;
                    while (i <= anzRunden)
                    {
                        Console.WriteLine("Du läufsts Runde " + i);
                        i++;
                    }  
                    Console.WriteLine("Geschafft! Du hast " + anzKm + " Kilometer / " + anzRunden + " Runden geschafft!");
                }
                else
                {
                    if (bereitInput == "Nein")
                    {
                        Console.WriteLine("Schade, vielleicht ein andermal.");
                    }
                    else
                    {
                        Console.WriteLine("Eingabefehler. Bitte antworte mit Ja oder Nein.");
                    }
                }
            }
            else
            {
                Console.WriteLine("Das schaffst du nicht, versuche etwas weniger als 42.");
            }
            Console.ReadKey();
        }
    }
}
