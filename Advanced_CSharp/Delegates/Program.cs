using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    delegate int Berechne(int x, int y);

    class Program
    {
        static void Main(string[] args)
        {
            Berechne berechne = new Berechne(Addition);
            int ergebnis = berechne(5, 4);
            Console.WriteLine("Das Ergebnis ist " + ergebnis);

            berechne = new Berechne(Subtraktion);
            ergebnis = berechne(118, 77);
            Console.WriteLine("Das Ergebnis ist " + ergebnis);

            Console.ReadKey();
        }

        static int Addition(int x, int y)
        {
            return x + y;
        }

        static int Subtraktion(int x, int y)
        {
            return x - y;
        }
    }
}
