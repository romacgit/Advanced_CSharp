using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Program
    {
        static void Main(string[] args)
        {
            ITier[] tierSammlung = new ITier[3];

            tierSammlung[0] = new Löwe(10, "Weibchen");
            tierSammlung[1] = new Hund(5, "Männchen");
            tierSammlung[2] = new Hund(8, "Weibchen");

            foreach (ITier tier in tierSammlung)
            {
                if (tier is Löwe)
                {
                    Console.WriteLine("Der Löwe ist " + tier.Alter + " und ein " + tier.Geschlecht);
                }
                else if (tier is Hund)
                {
                    Console.WriteLine("Der Hund ist " + tier.Alter + " und ein " + tier.Geschlecht);
                }
            }
            Console.ReadKey();
        }
    }
}
