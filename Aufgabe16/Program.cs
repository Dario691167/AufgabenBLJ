using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int randomIntInRange = random.Next(1, 101);
            Console.WriteLine("Gib eine Zahl ein.");
            GuessTheNumber(randomIntInRange);

        }
        static void GuessTheNumber(int randomIntInRange)
        {
            int attempts = 0;
            bool guessed = false;
            while (!guessed)
            {
                string input = Console.ReadLine();
                if (int.TryParse(input, out int userGuess))
                {
                    if (userGuess < randomIntInRange)
                    {
                        Console.WriteLine("Die Zahl ist größer.");
                        attempts++;
                    }
                    else if (userGuess > randomIntInRange)
                    {
                        Console.WriteLine("Die Zahl ist kleiner.");
                        attempts++;
                    }
                    else
                    {
                        attempts++;
                        Console.WriteLine("Die Zahl stimmt! Du hast " + attempts + " Versuche gebraucht");
                        PlayAgain(attempts);
                    }
                }
                else
                {
                    Console.WriteLine("Ungültige Eingabe. Bitte eine Zahl eingeben.");
                }
            }
        }
        static void PlayAgain(int userAttemps)
        {
            Console.WriteLine("Willst du nochmal spielen? (j/n)");
            string input = Console.ReadLine();
            if (input.ToLower() == "j")
            {
                Main(null);
            }
            else if (input.ToLower() == "n")
            {
                Console.WriteLine("Danke fürs Spielen!");
                Console.ReadKey();
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Ungültige Eingabe. Bitte 'j' oder 'n' eingeben.");
                PlayAgain(userAttemps);
            }
        }
    }
}
