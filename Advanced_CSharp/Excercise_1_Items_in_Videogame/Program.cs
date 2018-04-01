using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1_Items_in_Videogame
{
    class Program
    {
        static void Main(string[] args)
        {
            IItem[] items = new IItem[3];

            items[0] = new Potion(20, "Fireabsorber");
            items[1] = new Potion(10, "Healthpotion");
            items[2] = new Sword(50, "Killgravesword");

            items[0].Use();
            items[0].Sell();

            items[2].Use();
            items[2].Sell();

            foreach (IItem item in items)
                Console.WriteLine("You have a " + item.Name);

            Console.ReadKey();
        }
    }
}
