using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Abstract_Classes_and_Methods
{
    class Program
    {
        static void Main(string[] args)
        {
            Elektriker hendrik = new Elektriker();
            hendrik.ArbeitVerrichten();
            hendrik.Gehalt = 2500;
            Handwerker melvin = new Handwerker();
            melvin.Gehalt = 6000;
            melvin.ArbeitVerrichten();
            Mechatroniker frank = new Mechatroniker();
            frank.ArbeitVerrichten();

            Console.ReadKey();
        }
    }

   
}
