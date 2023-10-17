using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ÖvningAldor
{
    internal class Prescription
    {
        public string Medicine { get; set; }
        public DateTime Date { get; set; }

        public Prescription(string medicine)
        {
            Medicine = medicine;
            Date = DateTime.Now;
        }
    }
}