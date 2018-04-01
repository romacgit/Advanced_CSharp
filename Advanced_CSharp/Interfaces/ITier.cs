using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    interface ITier
    {
        // Eigenschaften
        int Alter { get; set; }
        string Geschlecht { get; set; }

        // Methodens
        void Essen();
        void Trinken();
    }
}
