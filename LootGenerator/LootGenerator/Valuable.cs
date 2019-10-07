using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator
{
    // Class for art objects and gemstones.
    class Valuable
    {
        // Attributes

        private string name;  // The name of the item.
        private int value;  // The value of the item in gp.
        private string type;  // Whether the item is a gemstone or art object.

        // Methods

        public string Getname()
        {
            return name;
        }
        
        public string Inspect()
        {
            string output = name + "\n\n\tA " + type + " worth " + String.Format("{0:n}", value) + " gold pieces.";
            return output;
        }
    }
}
