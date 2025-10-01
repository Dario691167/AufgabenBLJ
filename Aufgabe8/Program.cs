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
            string[] badWords = { "fuck", "hure", "hurensohn", "arsch", "arschloch", "fick", "bitch", "ass", "dumbass", "idiot", "bastard" };
            Console.WriteLine("Dein Kommentar");
            string comment = Console.ReadLine();
            string lowerComment = comment.ToLower();

            int badWordCount = 0;
            foreach (string badWord in badWords)
            {
                if (lowerComment.Contains(badWord))
                {
                    badWordCount++;
                }
            }

            if (badWordCount > 0)
            {
                Console.WriteLine("Dein Kommentar enthält " + badWordCount + " böse Wörter.");
                Console.WriteLine("Er wird nicht veröffentlicht.");
            }
            else
            {
                Console.WriteLine("Vielen Dank für deinen Kommentar.");
            }
            Console.ReadKey();
        }
    }
}
