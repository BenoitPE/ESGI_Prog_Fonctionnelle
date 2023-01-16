using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmation_Fonctionnelle.Common
{
    public static class Copyright
    {
        public static void print(string principle, string? description = null, string? details = null)
        {
            ConsoleColor consoleColor = ConsoleColor.Green;
            Console.WriteLine(">--------------------------------------------<");

            Console.Write("Author: ");
            Console.ForegroundColor = consoleColor;
            Console.WriteLine("Benoit PEGAZ & Aldrick CLERET - ESGI Lyon Master 2eme annee Architecture des Logiciels");
            Console.ResetColor();

            Console.Write("Principe de programmation fonctionnelle: ");
            Console.ForegroundColor = consoleColor;
            Console.WriteLine($"{principle}\n");
            Console.ResetColor();

            Console.Write("Description: ");
            Console.ForegroundColor = consoleColor;
            Console.WriteLine(description);
            Console.ResetColor();

            if (details != null)
            {
                Console.Write("Details: ");
                Console.ForegroundColor = consoleColor;
                Console.WriteLine(details);
                Console.ResetColor();
            }

            Console.WriteLine(">--------------------------------------------<\n");
        }
    }
}