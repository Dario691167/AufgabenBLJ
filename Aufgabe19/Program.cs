using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bool quit = false;
            while (!quit)
            {
                Console.Write("make your calculation (q to quit): ");
                string input = Console.ReadLine();
                if (input == "q")
                {
                    quit = true;
                }
                else
                {
                    double result = Calculate(input);
                    if (double.IsNaN(result))
                    {
                        Console.WriteLine("Ungültige Eingabe! Bitte gib z.B. 3+4, 5*6, 8/2, 7-1 oder 8/-2 ein.");
                    }
                    else
                    {
                        Console.WriteLine("Result: " + result);
                    }
                }
            }
        }

        static double Calculate(string input)
        {
            input = input.Replace(" ", "");
            char[] operators = { '+', '-', '*', '/' };
            int opIndex = -1;
            char op = '\0';

            for (int i = 1; i < input.Length; i++)
            {
                if (operators.Contains(input[i]))
                {
                    if (input[i] == '-' && operators.Contains(input[i - 1]))
                        continue;

                    opIndex = i;
                    op = input[i];
                    break;
                }
            }

            if (opIndex > 0)
            {
                string ersteNummer = input.Substring(0, opIndex);
                string zweiteNummer = input.Substring(opIndex + 1);
                p
                double a, b;
                bool okA = double.TryParse(ersteNummer, out a);
                bool okB = double.TryParse(zweiteNummer, out b);
                if (!okA || !okB)
                    return double.NaN;
                switch (op)
                {
                    case '+': return a + b;
                    case '-': return a - b;
                    case '*': return a * b;
                    case '/': return a / b;
                }
            }
            return double.NaN;
        }
    }
}
