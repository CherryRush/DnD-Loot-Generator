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

        public string name { private set; get; }  // The name of the item.
        private int value;  // The value of the item in gp.
        private string type;  // Whether the item is a gemstone or art object.

        // Methods

        public string GetName()  // Return the name of the valuable item.
        {
            return name;
        }

        public bool CheckName(string check)  // Check to see if the name of the item is the same as a test string.
        {
            if (check == name)
                return true;
            else
                return false;
        }

        public string Inspect()  // Output the item's description for txtInspect.
        {
            string output = name + "\r\n \r\nA " + type + " worth " + String.Format("{0:n}", value) + " gold pieces.";
            return output;
        }

        // Constructor

        public Valuable(string name, string type, int value)
        {
            this.name = name;
            this.value = value;
            this.type = type;
        }
    }
}
