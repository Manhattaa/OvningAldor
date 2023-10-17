using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningAldor
{
    internal class Doctor : Person
    {
        public int Salary { get; set; }
        public Doctor(string name, int salary) : base(name)
        {
            Salary = salary;
        }
        public void WritePrescription(string medicine)
        {
            Console.WriteLine($"Doctor {Name} has written a prescription for {medicine}");
        }
    }
}
