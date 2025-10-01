using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Breite des Stammes? ");
            int stammBreite = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe des Stammes? ");
            int stammHoehe = Convert.ToInt32(Console.ReadLine());
            Console.Write("Höhe der Krone? ");
            int kroneHoehe = Convert.ToInt32(Console.ReadLine());
            ErzBaumKrone(kroneHoehe);
                ErzBaumStamm(stammHoehe, stammBreite, kroneHoehe);
        }

        static void ErzBaumKrone(int kroneHoehe)
        {
            for (int i = 0; i < kroneHoehe; i++)
            {
                int krone = 2 * i + 1;
                int abstand = kroneHoehe - i - 1;
                Console.Write(new string(' ', abstand));
                Console.WriteLine(new string('*', krone));
            }
        }

        static void ErzBaumStamm(int stammHoehe, int stammBreite, int kroneHoehe)
        {
            int abstand = kroneHoehe - (stammBreite / 2) - 1;
            for (int i = 0; i < stammHoehe; i++)
            {
                Console.Write(new string(' ', abstand));
                Console.WriteLine(new string('*', stammBreite));
            }
        }
    }
}
