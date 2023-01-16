using Programmation_Fonctionnelle.Common;

namespace Programmation_Fonctionnelle.Principles
{
    public static class PureFunction
    {
        public static void Run()
        {
            Copyright.print("Fonction pure",
                "Une fonction pure est une fonction sans effet de bord, qui s'occupe uniquement de renvoyer une valeur, ne dépend que de ses paramètres d'entrée sans les modifier",
                "Ici Multiply() est une fonction pure car elle n'a pas d'effet de bord, elle retourne une valeur et ne modifie pas les paramètres d'entrée");
            int a = 3;
            int b = 4;
            Console.WriteLine($"a = {a}");
            Console.WriteLine($"b = {b}");
            Console.WriteLine($"a * b = {Multiply(a, b)}");
        }

        public static Func<int, int, int> Multiply = (a, b) => a * b;
    }
}
