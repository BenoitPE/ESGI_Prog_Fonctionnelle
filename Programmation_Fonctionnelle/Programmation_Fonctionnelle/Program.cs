namespace Programmation_Fonctionnelle
{
    public class Program
    {
        public static void Main()
        {
            while(true)
            {
                Console.WriteLine(">--------------------------------------------<");
                Console.WriteLine("Veuillez sélectionner un principe de Programmation fonctionnelle");
                Console.WriteLine("\t- 0: Fonction d'ordre supérieur");
                Console.WriteLine("\t- 1: Fonction pure");
                Console.WriteLine("\t- 2: Idempotence");
                Console.WriteLine("\t- 3: Immutabilité");
                Console.WriteLine("\t- 4: Composition de fonction (pure et impure");
                Console.WriteLine("\t- 5: Composition Over inheritance");
                Console.WriteLine("\t- 6: Séparation entre domaines purs et impurs");
                Console.WriteLine(">--------------------------------------------<");

                int value = Convert.ToInt32(Console.ReadLine());
                Console.Clear();
                switch (value)
                {
                    case 0:
                        HigherOrderFunctions.Run();
                        break;
                    case 2:
                        Idempotency.Run();
                        break;
                    default:
                        Console.Clear();
                        break;
                }
                Console.WriteLine("\nAPPUYEZ SUR ENTRER POUR REVENIR AU MENU");
                Console.ReadLine();
                Console.Clear();
            }

        }
    }
}
