using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningAldor
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Doctor doctor1 = new Doctor("Dr Aldor", 90000);
            Nurse nurse1 = new Nurse("Nurse Ratchet", "Day");
            Nurse nurse2 = new Nurse("House", "Night");

            Patient patient1 = new Patient("Malin", "Fever");
            patient1.GetPrescription("Alvedon");

            Patient patient2 = new Patient("Mojtaba", "Broken leg");

            Console.Write("Personal på sjukhuset:");
            Console.WriteLine($"{doctor1.Name}, {doctor1.Salary}");
            Console.WriteLine($"{nurse1.Name}, Shift: {nurse1.Shift}");
            Console.WriteLine($"{nurse2.Name}, Shift: {nurse2.Shift}");

            Console.WriteLine("\nPatientinformation:");
            Console.WriteLine($"Patient: {patient1.Name}, Diagnosis: {patient1.Diagnosis}, Prescription: {patient1.Prescription1}");
            Console.WriteLine($"Patient: {patient2.Name}, Diagnosis: {patient2.Diagnosis}, Prescription: {patient2.Prescription2}");
        }
    }
}
