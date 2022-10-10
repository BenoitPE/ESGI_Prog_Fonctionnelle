using Programmation_Fonctionnelle.Principles;

namespace Programmation_Fonctionnelle
{
    public class Program
    {
        public static void Main()
        {
            while (true)
            {
                Console.WriteLine(">--------------------------------------------<");
                Console.WriteLine("Veuillez sélectionner un principe de Programmation fonctionnelle");
                Console.WriteLine("\t- 1: Fonction d'ordre supérieur");
                Console.WriteLine("\t- 2: Fonction pure");
                Console.WriteLine("\t- 3: Idempotence");
                Console.WriteLine("\t- 4: Immutabilité");
                Console.WriteLine("\t- 5: Composition de fonction (pure et impure)");
                Console.WriteLine("\t- 6: Composition Over inheritance");
                Console.WriteLine("\t- 7: Séparation entre domaines purs et impurs");
                Console.WriteLine(">--------------------------------------------<");
                
                int value = 0;
                if (!int.TryParse(Console.ReadLine(), out value))
                    Environment.Exit(0);

                Console.Clear();
                switch (value)
                {
                    case 0:
                    default:
                        Environment.Exit(0);
                        break;
                    case 1:
                        HigherOrderFunctions.Run();
                        break;
                    case 2:
                        PureFunction.Run();
                        break;
                    case 3:
                        Idempotency.Run();
                        break;
                    case 4:
                        Immutability.Run();
                        break;
                    case 5:
                        CompositionOfFunctions.Run();
                        break;
                }
                Console.WriteLine("\n<Appuyez sur une touche pour revenir au menu>");
                Console.ReadLine();
                Console.Clear();
            }
        }
    }
}
