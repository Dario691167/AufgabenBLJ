using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Quersumme
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Zahl: ");
            int n = 0;
            while (int.TryParse(Console.ReadLine(), out n) == false)
            {
                Console.WriteLine("Ungültige Eingabe. Bitte geben Sie eine Ganzzahl ein.");
            }

            Console.WriteLine("Die Quersumme von " + n + " ist: " + Checksum(n));
            Console.ReadKey();
        }
        public static int Checksum(int n)
        {
            int sum = 0;
            n = Math.Abs(n); 
            while (n > 0)
            {
                int letzteZiffer = n % 10; 
                sum += letzteZiffer;       
                n = n / 10;               
            }
            return sum;
        }

    }
}