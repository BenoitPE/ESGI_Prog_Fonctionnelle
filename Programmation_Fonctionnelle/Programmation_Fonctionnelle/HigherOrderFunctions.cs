using Programmation_Fonctionnelle.Common;
using System;

namespace Programmation_Fonctionnelle
{
    public class HigherOrderFunctions
    {
        public const string FirstName = "Benoit";
        public const string LastName = "pegaz";
        public static void Main()
        {
            Copyright.print("Fonction d'ordre supérieur/ Higher-order function",
                "Une fonction d'ordre supérieure est une fonction qui prend et/ou renvoie une fonction",
                "Ici nous avons une méthode qui prend en paramètre une autre méthode");

            string res = PrintHelloText(FormatName);
            Console.WriteLine(res);

            Console.ReadLine();
        }

        /// <summary>
        /// Retourne le nom de l'utilisateur au format spécifié
        /// </summary>
        /// <param name="firstName">Le prénom de l'utilisateur</param>
        /// <param name="lastName">Le nom de l'utilisateur</param>
        /// <returns>Une chaine de caractère avec le prénom suivi du nom en majuscule</returns>
        public static string FormatName(string firstName, string lastName)
        {
            return $"{firstName} {lastName.ToUpper()}";
        }

        /// <summary>
        /// Retourne le message officiel
        /// </summary>
        /// <param name="formatName">La fonction qui retourne le nom d'utilisateur au format spécifié</param>
        /// <param name="firstName">Le prénom de l'utilisateur</param>
        /// <param name="lastName">Le nom de l'utilisateur</param>
        /// <returns>Retourne une chaine de caractère comportant le message officiel</returns>
        public static string PrintHelloText(Func<string, string, string> formatName)
        {
            return $"Welcome in our community {formatName(FirstName, LastName)}!";
        }
    }
}