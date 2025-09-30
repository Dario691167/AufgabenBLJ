using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] badWords = { "fuck", "hure", "hurensohn", "arsch", "arschloch", "fick", "bitch", "ass", "dumbass", "idiot, Bastard" };
            Console.WriteLine("Dein Kommentar");
            string comment = Console.ReadLine();
            string lowerComment = comment.ToLower();
            for (int i = 0; i < badWords.Length; i++;)
            {
                if (lowerComment.Contains(badWords[i]))
                {
                    Console.WriteLine("Dein Kommentar wurde wegen unangebrachter Sprache gelöscht.");
                    return;
                }
            }
        }
    }
}
