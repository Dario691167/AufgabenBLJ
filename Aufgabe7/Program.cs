using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 1;
            while (i <= 30)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    Console.Write(i +  ", ");
                    i++;
                }
                else
                {
                    i++;
                }
            }
        }
    }
}
