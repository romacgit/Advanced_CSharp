using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1_Items_in_Videogame
{
    class Sword : IItem
    {
        public Sword(int _goldVal, string _name)
        {
            GoldValue = _goldVal;
            Name = _name;
        }

        public int GoldValue { get; set; }
        public string Name { get; set; }

        public void Sell()
        {
            Console.WriteLine("Item sold for {0} gold!", GoldValue);
        }

        public void Use()
        {
            Console.WriteLine("You are attacking!");
        }
    }
}
