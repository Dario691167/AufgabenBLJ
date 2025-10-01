using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe13
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Wie Lange soll die Lienie sein?");
            Console.Write("Deine Eingabe: ");
            int lineHeight = Convert.ToInt32(Console.ReadLine());
            DrawLine(lineHeight);
        }

        static void DrawLine(int lineheight)
        {
            for (int posSpace = 1; posSpace <= lineheight; posSpace++)
            {

                int anzStarsBeforeSpace = posSpace - 1;
                Console.Write(new string('*', anzStarsBeforeSpace));
                Console.Write(" ");
                Console.WriteLine(new string('*', lineheight - anzStarsBeforeSpace -1));
            }
        }
    }
}
