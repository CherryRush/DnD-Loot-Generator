using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LootGenerator
{
    // A spell scroll.
    class Scroll
    {
        // Attributes

        private string name;  // The name of the spell on the scroll.
        private int level;  // The level of the spell on the scroll.
        private List<string> jobs;  // The character classes who can use this scroll. (Not counting rogues using Use Magic Device)


        // Methods

        public string GetName()  // Return the full name of the scroll, including "Scroll Of"
        {
            string output = "Scroll of " + name;
            return output;
        }

        // If the scroll's name matches the input, return true. Otherwise, return false.
        public bool CheckName(string check)
        {
            if (check == name)
                return true;
            else
                return false;
        }

        // Get the output for item inspection.
        public string Inspect()
        {
            // The first line of the inspect output is the name of the scroll.
            string output = GetName() + "\n";

            // The second line of the inspect output is the estimated value of the scroll, which is based on level/rarity.
            // Values for magic items in D&D 5e are fuzzy and characters are expected to negotiate and haggle.
            // Levels 0, 1: Common (50-100 gp)
            // Levels 2, 3: Uncommon (101-500 gp)
            // Levels 4, 5: Rare (501-5,000 gp)
            // Levels 6, 7, 8: Very Rare (5,001-50,000 gp)
            // Level 9: Legendary (50,0001+ gp)
            output += "Estimated Value: ";
            switch (level)
            {
                case 0:
                    output += "50-100 gp";
                    break;
                case 1:
                    output += "50-100 gp";
                    break;
                case 2:
                    output += "101-500 gp";
                    break;
                case 3:
                    output += "101-500 gp";
                    break;
                case 4:
                    output += "501-5,000 gp";
                    break;
                case 5:
                    output += "501-5,000 gp";
                    break;
                case 6:
                    output += "5,001-50,000 gp";
                    break;
                case 7:
                    output += "5,001-50,000 gp";
                    break;
                case 8:
                    output += "5,0001-50,000 gp";
                    break;
                case 9:
                    output += "50,001 gp";
                    break;
            }
            output += "\n\n";

            // The next lines should be the level of the spell and the spell lists it can be cast from.
            output += "Level: " + level.ToString() + "\n";
            output += "Spell Lists: ";
            foreach (string job in jobs)
            {
                output += job + ", ";
            }
            output += "\n\n";

            // Finally, add the description of the spell scroll, including its Save DC and Attack Bonus.
            output += "\tThis spell scroll allows the user to cast " + name + " with a Save DC of ";
            switch (level)
            {
                case 0:
                    output += "13";
                    break;
                case 1:
                    output += "13";
                    break;
                case 2:
                    output += "13";
                    break;
                case 3:
                    output += "15";
                    break;
                case 4:
                    output += "15";
                    break;
                case 5:
                    output += "17";
                    break;
                case 6:
                    output += "17";
                    break;
                case 7:
                    output += "18";
                    break;
                case 8:
                    output += "18";
                    break;
                case 9:
                    output += "19";
                    break;
            }
            output += " and an Attack Bonus of ";
            switch (level)
            {
                case 0:
                    output += "+5";
                    break;
                case 1:
                    output += "+5";
                    break;
                case 2:
                    output += "+5";
                    break;
                case 3:
                    output += "+7";
                    break;
                case 4:
                    output += "+7";
                    break;
                case 5:
                    output += "+9";
                    break;
                case 6:
                    output += "+9";
                    break;
                case 7:
                    output += "+10";
                    break;
                case 8:
                    output += "+10";
                    break;
                case 9:
                    output += "+11";
                    break;
            }
            output += ". After this scroll is used, it will crumble to dust even if the spell cast was unsuccessful.";
            return output;
        }

        // Determine if the scroll matches a spell level and class list.
        public bool IsValid(List<string> jobs, int level)
        {
            if (this.jobs.Intersect(jobs).Any())
            {
                if (this.level == level)
                    return true;
                else
                    return false;
            }
            else
                return false;
        }

        // Constructor

        public Scroll(string name, int level, List<string> jobs)
        {
            this.name = name;
            this.level = level;
            this.jobs = jobs;
        }
    }
}
