using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int Num1;
            int Num2;
            Console.WriteLine("Dieses Programm berechnet die Summe von 2 Zahlen");
            Console.Write("Zahl 1: ");
            Num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Zahl 2: ");
            Num2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine(Num1 + Num2);

        }
    }
}
