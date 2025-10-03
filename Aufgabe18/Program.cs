using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe18
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Deine Eingabe: ");
            string satz = Console.ReadLine();
            string satzKlein = satz.ToLower();
            ZähleVokale(satzKlein);
            Console.WriteLine("Dein Satz hat total " + ZähleVokale(satzKlein) + " Vokale.");
            ZähleA(satzKlein);
            Console.WriteLine("Dein Satz hat " + ZähleA(satzKlein) + " mal 'a' drinnen.");
            ZähleE(satzKlein);
            Console.WriteLine("Dein Satz hat " + ZähleE(satzKlein) + " mal 'e' drinnen.");
            ZähleI(satzKlein);
            Console.WriteLine("Dein Satz hat " + ZähleI(satzKlein) + " mal 'i' drinnen.");
            ZähleO(satzKlein);
            Console.WriteLine("Dein Satz hat " + ZähleO(satzKlein) + " mal 'o' drinnen.");
            ZähleU(satzKlein);
            Console.WriteLine("Dein Satz hat " + ZähleU(satzKlein) + " mal 'u' drinnen.");
            Zähleä(satzKlein);
            Console.WriteLine("Dein Satz hat " + Zähleä(satzKlein) + " mal 'ä' drinnen.");
            Zähleö(satzKlein);
            Console.WriteLine("Dein Satz hat " + Zähleö(satzKlein) + " mal 'ö' drinnen.");
            Zähleü(satzKlein);
            Console.WriteLine("Dein Satz hat " + Zähleü(satzKlein) + " mal 'ü' drinnen.");
        }

        static int ZähleVokale(string satz)
        {
            if (string.IsNullOrEmpty(satz))
            {
                return 0;
            }

            string vowels = "aeiouAEIOU";
            int count = 0;

            foreach (char letter in satz)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
        static int ZähleA(string satz)
        {
            if (string.IsNullOrEmpty(satz))
            {
                return 0;
            }

            string vowels = "a";
            int count = 0;

            foreach (char letter in satz)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
        static int ZähleE(string satz)
        {
            if (string.IsNullOrEmpty(satz))
            {
                return 0;
            }

            string vowels = "e";
            int count = 0;

            foreach (char letter in satz)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
        static int ZähleI(string satz)
        {
            if (string.IsNullOrEmpty(satz))
            {
                return 0;
            }

            string vowels = "i";
            int count = 0;

            foreach (char letter in satz)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
        static int ZähleO(string satz)
        {
            if (string.IsNullOrEmpty(satz))
            {
                return 0;
            }

            string vowels = "o";
            int count = 0;

            foreach (char letter in satz)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
        static int ZähleU(string satz)
        {
            if (string.IsNullOrEmpty(satz))
            {
                return 0;
            }

            string vowels = "u";
            int count = 0;

            foreach (char letter in satz)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
        static int Zähleä(string satz)
        {
            if (string.IsNullOrEmpty(satz))
            {
                return 0;
            }

            string vowels = "ä";
            int count = 0;

            foreach (char letter in satz)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
        static int Zähleö(string satz)
        {
            if (string.IsNullOrEmpty(satz))
            {
                return 0;
            }

            string vowels = "ö";
            int count = 0;

            foreach (char letter in satz)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
        static int Zähleü(string satz)
        {
            if (string.IsNullOrEmpty(satz))
            {
                return 0;
            }

            string vowels = "ü";
            int count = 0;

            foreach (char letter in satz)
            {
                if (vowels.Contains(letter))
                {
                    count++;
                }
            }

            return count;
        }
    }
}
