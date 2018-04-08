using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Structs
{
    class Program
    {
        static void Main(string[] args)
        {
            Buch buchEins = new Buch("C# für Anfänger", "Robert Mac", 800);
            Buch buchZwei;
            buchZwei.autor = "Rober Mac";
            buchZwei.titel = "Java für Anfänger";
            buchZwei.seitenanzahl = 800;

            Console.WriteLine(buchEins.titel);
            Console.WriteLine(buchEins.autor);
            Console.WriteLine(buchEins.seitenanzahl);
            Console.WriteLine(buchZwei.seitenanzahl);

            Console.ReadKey();
        }
    }

    struct Buch
    {
        public string titel;
        public string autor;
        public int seitenanzahl;

        public Buch(string _titel, string _autor, int _seitenanzahl)
        {
            titel = _titel;
            autor = _autor;
            seitenanzahl = _seitenanzahl;
        }
    } 
}
