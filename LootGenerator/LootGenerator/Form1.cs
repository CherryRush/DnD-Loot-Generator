using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LootGenerator
{
    public partial class Form1 : Form
    {
        /*TO-DO LIST:
            1) Complete scroll list from the Player's Handbook.
            2) Add scroll list from Xanathar's Guide to Everything.
            3) Add list of gemstones and art objects.
            4) Add list of non-scroll magic items.
            5) Complete Treasure Hoard generation.
            6) Add inspect box functionality.
            7) Complete Treasure parcel generation.*/

        // A list of all spell scrolls available to the loot generator.
        List<Scroll> ScrollIndex = new List<Scroll>();

        // This method adds all spell scrolls from the Player's Handbook.
        private void standardScrollList()
        {
            ScrollIndex.Add(new Scroll("Acid Splash", 0, new List<string> {"Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Aid", 2, new List<string> { "Cleric", "Paladin" }));
            ScrollIndex.Add(new Scroll("Alarm", 1, new List<string> {"Ranger", "Wizard"}));
            ScrollIndex.Add(new Scroll("Alter Self", 2, new List<string> {"Wizard", "Sorcerer"}));
            ScrollIndex.Add(new Scroll("Acid Splash", 0, new List<string> { "Sorcerer", "Wizard" }));
            ScrollIndex.Add(new Scroll("Animal Friendship", 1, new List<string> { "Bard", "Druid", "Ranger"}));
            ScrollIndex.Add(new Scroll("Animal Messenger", 2, new List<string> {"Bard", "Druid", "Ranger"}));
            ScrollIndex.Add(new Scroll("Animal Shapes", 8, new List<string> { "Druid"}));
            ScrollIndex.Add(new Scroll("Animate Dead", 3, new List<string> { "Cleric", "Wizard" }));
            ScrollIndex.Add(new Scroll("Animate Objects", 5, new List<string> { "Bard", "Sorcerer", "Wizard" }));
            ScrollIndex.Add(new Scroll("Antilife Shell", 5, new List<string> { "Druid", "Wizard" }));
            ScrollIndex.Add(new Scroll("Antimagic Field", 8, new List<string> { "Cleric", "Wizard" }));
            ScrollIndex.Add(new Scroll("Antipathy/Sympathy", 8, new List<string> { "Druid", "Wizard" }));
            ScrollIndex.Add(new Scroll("Arcane Eye", 4, new List<string> {"Wizard" }));
            ScrollIndex.Add(new Scroll("Arcane Gate", 6, new List<string> { "Sorcerer", "Wizard", "Warlock" }));
            ScrollIndex.Add(new Scroll("Arcane Lock", 2, new List<string> { "Wizard" }));
            ScrollIndex.Add(new Scroll("Armor of Agathys", 1, new List<string> { "Warlock" }));
            ScrollIndex.Add(new Scroll("Arms of Hadar", 1, new List<string> { "Warlock" }));
            ScrollIndex.Add(new Scroll("Astral Projection", 9, new List<string> { "Cleric", "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Augury", 2, new List<string> { "Cleric"}));
            ScrollIndex.Add(new Scroll("Aura of Life", 4, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Aura of Purity", 4, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Aura of Vitality", 3, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Awaken", 5, new List<string> { "Bard", "Druid" }));
            ScrollIndex.Add(new Scroll("Bane", 1, new List<string> { "Bard", "Cleric"}));
        }

        // Form Constructor
        public Form1()
        {
            cmbHoardCR.SelectedIndex = 0;  // Set the initial Selected index for the Hoard CR combobox.
            InitializeComponent();
        }

        // When radHoard is checked, disable/hide the Parcels group box and
        // enable/show the Hoards group box.
        private void radHoard_CheckedChanged(object sender, EventArgs e)
        {
            if (radHoard.Checked == true)
            {
                grpParcels.Enabled = false;
                grpParcels.Visible = false;
                grpHoards.Visible = true;
                grpHoards.Enabled = true;
            }
        }

        // When radParcels is checked, disable/hide the Hoards group box and
        // enable/show the Parcels group box.
        private void radParcels_CheckedChanged(object sender, EventArgs e)
        {
            if (radParcels.Checked == true)
            {
                grpHoards.Enabled = false;
                grpHoards.Visible = false;
                grpParcels.Visible = true;
                grpParcels.Enabled = true;
            }
        }

        // Treasure Generation
        private void btnGenerate_Click(object sender, EventArgs e)
        {
            // Declare attributes and objects.
            int level;  // Party level for parcels and monster CR for hoards.
            List<string> spell_lists = new List<string>();  // Spell lists to generate scrolls from.
            bool staticvalues;  // If true, use average values for currency, gems, and art objects.
            bool manualitems;  // If true, use placeholder strings for permanent/major magic items.
            Random die = new Random();  // A Random object to roll on tables.

            // If radHoards is checked, generate a random treasure hoard.
            if (radHoard.Checked == true)
            {
                level = cmbHoardCR.SelectedIndex;
                staticvalues = chkHoardStaticValues.Checked;
                manualitems = chkHoardManualItems.Checked;
            }
            // If radParcels is checked, generate a random treasure parcel.
            else
            {
                level = Convert.ToInt32(nudParcelLevel.Value);
                staticvalues = false;
                manualitems = chkParcelManualItems.Checked;
            }
        }
    }
}
