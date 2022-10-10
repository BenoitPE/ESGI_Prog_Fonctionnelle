using Programmation_Fonctionnelle.Common;

namespace Programmation_Fonctionnelle.Principles
{
    public static class Idempotency
    {
        public static void Run()
        {
            Copyright.print("Fonction d'idempotence",
                "Une fonction d'idempotence est une fonction qui retourne le même résultat qu'elle soit exécutée une ou plusieurs fois",
                @"La méthode ToUpper() est un bon exemple d'idempotence car quel que soit le nombre d'exécution entre 1 et infini avec un même paramètre d'entrée, le résultat sera le même.
Ici, dans notre cas, 'Bonjour je suis un exemple d'idempotence' passera en majuscule lors du premier appel de ToUppercase(), et restera en majuscule quel que soit le nombre d'itération de ToUppercase()");

            string text = "Bonjour je suis un exemple d'idempotence";
            Console.WriteLine(text);

            text = ToUppercase(text);
            Console.WriteLine(text);

            text = ToUppercase(text);
            Console.WriteLine(text);
        }

        /// <summary>
        /// Retourne une chaine de caractères en majuscule
        /// </summary>
        /// <param name="text">Un texte passé en paramètre</param>
        /// <returns>Retourne une chaine de caractères en majuscule</returns>
        private static string ToUppercase(string text)
        {
            return text.ToUpper();
        }
    }
}
