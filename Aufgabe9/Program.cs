using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool end = false;
            while (!end)
            {
                Console.WriteLine("Gib eine Zahl ein (oder 'q' zum Beenden):");
                string input = Console.ReadLine();

                if (input.ToLower() == "q")
                {
                    end = true;
                }
                else
                {
                    int zahl;
                    if (int.TryParse(input, out zahl) && zahl >= 0)
                    {
                        string bin = "";
                        int originalZahl = zahl;
                        if (zahl == 0)
                        {
                            bin = "0";
                        }
                        else
                        {
                            while (zahl > 0)
                            {
                                int rest = zahl % 2;
                                bin = rest.ToString() + bin;
                                zahl = zahl / 2;
                            }
                        }
                        Console.WriteLine("Die binäre Darstellung von " + originalZahl + " ist: " + bin);
                    }
                    else
                    {
                        Console.WriteLine("Ungültige Eingabe. Bitte gib eine positive ganze Zahl ein oder 'q' zum Beenden.");
                    }
                }
            }
        }
    }
}
