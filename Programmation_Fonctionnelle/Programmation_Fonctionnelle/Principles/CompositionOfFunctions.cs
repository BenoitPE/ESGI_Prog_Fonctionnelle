using Programmation_Fonctionnelle.Common;

namespace Programmation_Fonctionnelle.Principles
{
    public static class CompositionOfFunctions
    {
        public static void Run()
        {
            Copyright.print("Composition de fonctions (pures et impure)",
                "La composition de deux fonctions est l'application de la première fonction au résultat de l'application de la seconde",
                @"Ici AddOne() est une fonction impure car elle modifie la valeur du paramètre d'entrée
Multiply() est une fonction pure car elle ne crée pas d'effet de bord et ne modifie pas les paramètres d'entrées
Multiply(a, AddOne(ref b)) est une composition de fonction pure et impure");

            int a = 3;
            Console.WriteLine($"a = {a}");

            int b = 4;
            Console.WriteLine($"b = {b}");

            int c = Multiply(a, AddOne(ref b));
            Console.WriteLine($"c = a * (b+1) = {c}");
            Console.WriteLine($"b (Nouvelle valeur) = {b}");
        }

        /// <summary>
        /// Ajoute 1 au paramètre d'entrée (fonction impure)
        /// </summary>
        /// <param name="value">La référence de la variable</param>
        /// <returns>Le résultat du paramètre d'entrée + 1</returns>
        public static int AddOne(ref int value)
        {
            value = value + 1;
            return value;
        }

        /// <summary>
        /// Multiplie a par b (Fonction pure)
        /// </summary>
        /// <param name="a"></param>
        /// <param name="b"></param>
        /// <returns>Le résultat de la multiplication de a par b</returns>
        public static int Multiply(int a, int b)
        {
            return a * b;
        }
    }
}
