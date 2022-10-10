using Programmation_Fonctionnelle.Common;

namespace Programmation_Fonctionnelle.Principles
{
    public sealed class ImmutablePerson
    {
        private string FirstName { get; }
        private string LastName { get; }

        public ImmutablePerson(string firstName, string lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return $"Personne immutable ({FirstName} {LastName}) créée";
        }
    }

    public static class Immutability
    {
        public static void Run()
        {
            Copyright.print("Fonction d'immutabilité",
                "La classe ImmutablePerson est une classe immutable car les propriétés n'ont pas de setter et la classe n'est pas surchargeable");

            ImmutablePerson person = new ImmutablePerson("Benoit", "PEGAZ");
            Console.WriteLine(person.ToString());
        }
    }
}
