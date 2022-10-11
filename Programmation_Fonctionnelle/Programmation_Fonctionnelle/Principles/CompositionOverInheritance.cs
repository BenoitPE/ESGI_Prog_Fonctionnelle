using Programmation_Fonctionnelle.Common;

namespace Programmation_Fonctionnelle.Principles
{
    public class Company
    {
        private string Name { get; set; }
        private int NumberOfEmmployees { get; set; }

        public Company(string name, int numberOfEmployees)
        {
            Name = name;
            NumberOfEmmployees = numberOfEmployees;
        }
        public override string ToString()
        {
            return $"Nom d'entreprise: {Name},\nNombre d'employés: {NumberOfEmmployees}";
        }
    }

    public class DigitalServicesCompany
    {
        private Company Company { get; set; }
        private int NumberOfDevelopers { get; set; }

        public DigitalServicesCompany(Company company, int numberOfDevelopers)
        {
            Company = company;
            NumberOfDevelopers = numberOfDevelopers;
        }
        public override string ToString()
        {
            return $"{Company},\nNombre de développeurs: {NumberOfDevelopers}";
        }
    }

    public static class CompositionOverInheritance
    {
        public static void Run()
        {
            Copyright.print("Composition Over Inheritance",
    "La composition plutôt que l'héritage est le fait d'éviter d'utiliser l'héritage et de favoriser la composition",
    @"Dans notre cas, ici nous pouvons voir une composition entre les classes Company et DigitalServicesCompany 
(au lieu que DigitalServicesCompany hérite de Company)");

            DigitalServicesCompany digitalServicesCompany = new DigitalServicesCompany(new Company("ESN", 50), 10);
            Console.WriteLine(digitalServicesCompany.ToString());
        }
    }
}
