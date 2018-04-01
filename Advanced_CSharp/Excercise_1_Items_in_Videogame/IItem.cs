using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise_1_Items_in_Videogame
{
    interface IItem
    {
        // Properties
        int GoldValue { get; set; }
        string Name { get; set; }

        // Methods
        void Use();
        void Sell();

    }
}
