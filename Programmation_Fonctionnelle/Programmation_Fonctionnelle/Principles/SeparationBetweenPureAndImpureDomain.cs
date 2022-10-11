using Programmation_Fonctionnelle.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Programmation_Fonctionnelle.Principles
{
    /// <summary>
    /// ComptabilityService est une simulation d'un service pur. Nous ne tenons pas compte du Console.WriteLine() qui est seulement présent pour illustrer notre exemple
    /// </summary>
    public class ComptabilityService
    {
        /// <summary>
        /// Calcule le taux horaire
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="hours"></param>
        /// <returns>Le taux horaire calculé</returns>
        public double CalculateHourlyRate(double salary, double hours)
        {
            double hourlyRate = salary / hours;
            Console.WriteLine($"Le taux horaire calculé est de {hourlyRate} euros");
            return hourlyRate;
        }

        /// <summary>
        /// Calcule le salaire
        /// </summary>
        /// <param name="hourlyRate"></param>
        /// <param name="hours"></param>
        /// <returns>Le salaire calculé</returns>
        public double CalculateSalary(double hourlyRate, double hours)
        {
            double salary = hourlyRate * hours;
            Console.WriteLine($"Le salaire calculé est de {salary} euros");
            return salary;
        }
    }

    /// <summary>
    /// ExportService est une simulation d'un service impur car dépendant d'une librairie externe qui peut créer des effets de bord.
    /// </summary>
    public class ExportService
    {
        /// <summary>
        /// Exporte en PDF à l'aide d'une librairie externe
        /// </summary>
        /// <param name="data"></param>
        public void SaveAsPdf(string data)
        {
            Console.WriteLine("Nous simulons un export au format PDF à l'aide d'une librairie externe");
        }

        /// <summary>
        /// Exporte en CSV à l'aide d'une librairie externe
        /// </summary>
        /// <param name="data"></param>
        public void SaveAsCsv(string data)
        {
            Console.WriteLine("Nous simulons un export au format CSV à l'aide d'une librairie externe");
        }
    }

    public class ComptabilityController
    {
        ComptabilityService ComptabilityService { get; set; }
        ExportService ExportService { get; set; }

        public ComptabilityController()
        {
            ComptabilityService = new ComptabilityService();
            ExportService = new ExportService();
        }

        /// <summary>
        /// Calcule le taux horaire et l'exporte (Exemple d'implémentation mélangeant des appels de fonctions pur et impur)
        /// </summary>
        /// <param name="salary"></param>
        /// <param name="hours"></param>
        public void CalculateHourlyRateAndExportAsPdf(double salary, double hours)
        {
            double hourlyRate = ComptabilityService.CalculateHourlyRate(salary, hours);
            ExportService.SaveAsPdf(hourlyRate.ToString());
        }

        /// <summary>
        /// Calcule le salaire et l'exporte (Exemple d'implémentation mélangeant des appels de fonctions pur et impur)
        /// </summary>
        /// <param name="hourlyRate"></param>
        /// <param name="hours"></param>
        public void CalculateSalaryAndExportAsCsv(double hourlyRate, double hours)
        {
            double salary = ComptabilityService.CalculateSalary(hourlyRate, hours);
            ExportService.SaveAsCsv(salary.ToString());
        }
    }

    public static class SeparationBetweenPureAndImpureDomain
    {
        public static void Run()
        {
            Copyright.print("Séparation entre domaine pure et impur",
                details: @"Ici notre séparation se fait dans les services, le service ComptabilityService contient du code métier pur
ExportService appelle une librairie afin d'exporter en plusieurs format, Export service est du code impur");

            ComptabilityController comptabilityController = new ComptabilityController();
            comptabilityController.CalculateHourlyRateAndExportAsPdf(3034, 151.7);
            comptabilityController.CalculateSalaryAndExportAsCsv(151.7, 20);
        }

    }
}
