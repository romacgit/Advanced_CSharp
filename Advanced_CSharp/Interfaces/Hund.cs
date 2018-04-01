using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    class Hund : ITier
    {

        // Konstruktor
        public Hund(int _alter, string _geschlecht)
        {
            Alter = _alter;
            Geschlecht = _geschlecht;
        }

        public int Alter { get; set; }
        public string Geschlecht { get; set; }

        public void Essen()
        {
            Console.WriteLine("Der Hund isst...");
        }

        public void Trinken()
        {
            Console.WriteLine("Der Hund trinkt...");
        }

        public void Bellen()
        {
            Console.WriteLine("Der Hund bellt...");
        }
    }
}
