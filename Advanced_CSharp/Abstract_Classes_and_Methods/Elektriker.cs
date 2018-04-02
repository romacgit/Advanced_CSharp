using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Methods
{
    class Elektriker : Arbeiter
    {
        public override void ArbeitVerrichten()
        {
            Console.WriteLine("Der Elektriker öffnet den Stromkasten");
        }
    }
}
