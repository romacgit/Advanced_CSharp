using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeratoren
{
    enum Wochentag
    {
        Montag = 1,
        Dienstag,
        Mittwoch,
        Donnerstag,
        Freitag,
        Samstag,
        Sonntag
    }

    class Program
    {
        static void Main(string[] args)
        {
            Wochentag tag = Wochentag.Sonntag;

            switch (tag)
            {
                case Wochentag.Montag:
                    Console.WriteLine("Es ist Montag");
                    break;


                case Wochentag.Dienstag:
                    Console.WriteLine("Es ist Dienstag");
                    break;
                default:
                    Console.WriteLine("Es ist ein anderer Tag");
                    break;
            }
            Console.ReadKey();
        }
    }
}
