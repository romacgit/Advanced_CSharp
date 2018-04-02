using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polymorphism
{
    class Program
    {
        static void Main(string[] args)
        {
            Begrüßung("Robert");
            Begrüßung("Vanessa", 25);
            Begrüßung("Lisa", false);

            Console.ReadKey();
        }

        static void Begrüßung(string name)
        {
            Console.WriteLine("Hallo mein Name ist " + name);
        }

        static void Begrüßung(string name, int alter)
        {
            Console.WriteLine("Hallo mein Name ist " + name + " und bin {0} Jahre alt", alter);
        }

        static void Begrüßung(string name, bool verheiratet)
        {
            if (verheiratet)
                Console.WriteLine("Hallo mein Name ist " + name + " und ich bin verheiratet");
            else
                Console.WriteLine("Hallo mein Name ist " + name + " und ich bin nicht verheiratet");
        }
    }
}
