using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            Wertebehälter<int> behälter = new Wertebehälter<int>(15);
            behälter.Ausgabe();

            Wertebehälter<string> behälterZwei = new Wertebehälter<string>("Schönes Wetter");
            behälterZwei.Ausgabe();

            ObjectToText texter = new ObjectToText();
            texter.Ausgabe<int>(55);
            texter.Ausgabe<string>("Guten Tag");

            Console.ReadKey();
        }
    }

    public class Wertebehälter<T>
    {
        // Variablen
        private T MeinWert;

        public Wertebehälter(T _wert)
        {
            MeinWert = _wert;
        }

        public void Ausgabe()
        {
            Console.WriteLine(MeinWert.ToString());
        }
    }

    public class ObjectToText
    {
        // Methoden
        public void Ausgabe<T>(T myObject)
        {
            Console.WriteLine(myObject.ToString());
        }
    }
}
