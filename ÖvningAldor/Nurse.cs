using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningAldor
{
    internal class Nurse : Person
    {
        public string Shift {  get; set; }

        public Nurse(string name, string shift) : base(name)
        {
            Shift = shift;
        }
        public void TakeBloodTest()
        {
            Console.WriteLine($"Nurse {Name} is taking a blood test.");
        }
    }
}
