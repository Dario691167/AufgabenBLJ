using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = 10;

            Console.WriteLine("- - - - - -");
            Console.WriteLine("Kleines 1x1");
            Console.WriteLine("- - - - - -");
            for (int i = 1; i <= size; i++)
            {
                for (int j = 1; j <= size; j++)
                {
                    Console.Write($"{i * j,4} \t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }

    }
}
