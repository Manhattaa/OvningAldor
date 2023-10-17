using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningAldor
{
    internal class Patient : Person
    {
        public string Diagnosis { get; set; }
        public string Prescription1 { get; set; }
        public string Prescription2 { get; set; }
        public Patient(string name, string diagnosis) : base(name)
        {
            Diagnosis = diagnosis;
        }
        public void GetPrescription(string medicine)
        {
            Console.WriteLine($"A prescription of medicine {medicine}");
        }
    }
}
