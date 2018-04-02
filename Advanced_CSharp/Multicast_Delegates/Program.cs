using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Multicast_Delegates
{
    delegate void Ausgabe();

    class Program
    {
        static void Main(string[] args)
        {
            Ausgabe ausgabe = Begrüßung;
            ausgabe += Smalltalk;
            ausgabe += Verabschiedung;

            ausgabe();

            Console.ReadKey();

        }

        static void Begrüßung()
        {
            Console.WriteLine("Hallo!");
        }

        static void Smalltalk()
        {
            Console.WriteLine("Das Wetter ist echt schön!");
        }

        static void Verabschiedung()
        {
            Console.WriteLine("Tschüß!");
        }
    }
}
