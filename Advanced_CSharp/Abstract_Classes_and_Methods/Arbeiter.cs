using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Methods
{
    abstract class Arbeiter
    {
        // Eigenschaften
        public string Namen { get; set; }
        public double Gehalt { get; set; }

        // Methoden
        public virtual void ArbeitVerrichten()
        {
            Console.WriteLine("Der Arbeiter macht seine Arbeit");
        }
    }
}
