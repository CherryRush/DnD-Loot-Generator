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
            4) Add list of non-scroll magic items.
            5) Complete Treasure Hoard generation.
            6) Add magic items to the inspect box method.
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
            ScrollIndex.Add(new Scroll("Banishing Smite", 5, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Banishment", 4, new List<string> { "Cleric", "Sorcerer", "Wizard", "Warlock" }));
            ScrollIndex.Add(new Scroll("Barkskin", 2, new List<string> { "Druid", "Ranger" }));
            ScrollIndex.Add(new Scroll("Beacon of Hope", 3, new List<string> { "Cleric" }));
            ScrollIndex.Add(new Scroll("Beast Sense", 2, new List<string> { "Druid", "Ranger" }));
            ScrollIndex.Add(new Scroll("Bestow Curse", 3, new List<string> { "Bard", "Cleric", "Wizard" }));
            ScrollIndex.Add(new Scroll("Bigby's Hand", 5, new List<string> { "Wizard" }));
            ScrollIndex.Add(new Scroll("Blade Barrier", 6, new List<string> { "Cleric" }));
            ScrollIndex.Add(new Scroll("Blade Ward", 0, new List<string> { "Bard", "Sorcerer", "Warlock", "Wizard" }));
            ScrollIndex.Add(new Scroll("Bless", 1, new List<string> { "Cleric", "Paladin" }));
            ScrollIndex.Add(new Scroll("Blight", 4, new List<string> { "Druid", "Sorcerer", "Warlock", "Wizard" }));
            ScrollIndex.Add(new Scroll("Blinding Smite", 3, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Blindness/Deafness", 2, new List<string> { "Bard", "Cleric", "Sorcerer", "Wizard" }));
            ScrollIndex.Add(new Scroll("Blink", 3, new List<string> { "Sorcerer", "Wizard" }));
            ScrollIndex.Add(new Scroll("Blur", 2, new List<string> { "Sorcerer", "Wizard" }));
            ScrollIndex.Add(new Scroll("Branding Smite", 2, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Burning Hands", 1, new List<string> { "Sorcerer", "Wizard" }));
            ScrollIndex.Add(new Scroll("Call Lightning", 3, new List<string> { "Druid" }));
            ScrollIndex.Add(new Scroll("Calm Emotions", 2, new List<string> { "Bard", "Cleric" }));
            ScrollIndex.Add(new Scroll("Chain Lightning", 6, new List<string> { "Wizard", "Sorcerer" }));
            ScrollIndex.Add(new Scroll("Charm Person", 1, new List<string> {"Bard", "Druid", "Sorcerer", "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Chill Touch", 0, new List<string> { "Wizard", "Sorcerer", "Warlock"}));
            ScrollIndex.Add(new Scroll("Chromatic Orb", 1, new List<string> { "Wizard", "Sorcerer" }));
            ScrollIndex.Add(new Scroll("Circle of Death", 6, new List<string> { "Wizard", "Sorcerer", "Warlock"}));
            ScrollIndex.Add(new Scroll("Circle of Power", 5, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Clairvoyance", 3, new List<string> { "Wizard", "Sorcerer","Cleric","Bard"}));
            ScrollIndex.Add(new Scroll("Clone", 8, new List<string> { "Wizard" }));
            ScrollIndex.Add(new Scroll("Cloud of Daggers", 2, new List<string> {"Bard", "Sorcerer", "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Cloudkill", 5, new List<string> { "Sorcerer", "Wizard" }));
            ScrollIndex.Add(new Scroll("Color Spray", 1, new List<string> { "Wizard", "Sorcerer" }));
            ScrollIndex.Add(new Scroll("Command", 1, new List<string> {"Cleric", "Paladin"}));
            ScrollIndex.Add(new Scroll("Commune", 5, new List<string> {"Cleric"}));
            ScrollIndex.Add(new Scroll("Commune with Nature", 5, new List<string> { "Druid", "Ranger" }));
            ScrollIndex.Add(new Scroll("Compelled Duel", 1, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Comprehend Language", 1, new List<string> { "Wizard", "Bard", "Sorcerer", "Warlock"}));
            ScrollIndex.Add(new Scroll("Compulsion", 4, new List<string> {"Bard"}));
            ScrollIndex.Add(new Scroll("Cone of Cold", 5, new List<string> { "Wizard", "Sorcerer"}));
            ScrollIndex.Add(new Scroll("Confusion", 4, new List<string> {"Bard", "Druid", "Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Conjure Animals", 3, new List<string> {"Druid"}));
            ScrollIndex.Add(new Scroll("Conjure Barrage", 3, new List<string> {"Ranger"}));
            ScrollIndex.Add(new Scroll("Conjure Celestial", 7, new List<string> { "Cleric" }));
            ScrollIndex.Add(new Scroll("Conjure Elemental", 5, new List<string> {"Druid", "Wizard"}));
            ScrollIndex.Add(new Scroll("Conjure Fey", 6, new List<string> {"Druid", "Warlock"}));
            ScrollIndex.Add(new Scroll("Conjure Minor Elementals", 4, new List<string> { "Druid", "Wizard" }));
            ScrollIndex.Add(new Scroll("Conjure Volley", 5, new List<string> { "Ranger" }));
            ScrollIndex.Add(new Scroll("Conjure Woodland Beings", 4, new List<string> {"Druid", "Ranger"}));
            ScrollIndex.Add(new Scroll("Contact Other Plane", 5, new List<string> {"Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Contagion", 5, new List<string> { "Cleric", "Druid" }));
            ScrollIndex.Add(new Scroll("Contingency", 6, new List<string> { "Wizard" }));
            ScrollIndex.Add(new Scroll("Continual Flame", 2, new List<string> { "Cleric", "Wizard" }));
            ScrollIndex.Add(new Scroll("Control Water", 4, new List<string> { "Cleric", "Druid", "Wizard" }));
            ScrollIndex.Add(new Scroll("Control Weather", 8, new List<string> { "Cleric", "Druid", "Wizard" }));
            ScrollIndex.Add(new Scroll("Cordon of Arrows", 2, new List<string> { "Ranger" }));
            ScrollIndex.Add(new Scroll("Counterspell", 3, new List<string> {"Sorcerer","Warlock","Wizard"}));
            ScrollIndex.Add(new Scroll("Create Food and Water", 3, new List<string> { "Cleric", "Paladin" }));
            ScrollIndex.Add(new Scroll("Create or Destroy Water", 1, new List<string> { "Cleric", "Druid"}));
            ScrollIndex.Add(new Scroll("Create Undead", 6, new List<string> { "Cleric", "Wizard"}));
            ScrollIndex.Add(new Scroll("Creation", 5, new List<string> {"Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Crown of Madness", 2, new List<string> { "Bard", "Sorcerer", "Warlock", "Wizard" }));
            ScrollIndex.Add(new Scroll("Crusader's Mantle", 3, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Cure Wounds", 7, new List<string> { "Cleric", "Bard", "Druid", "Paladin", "Ranger" }));
            ScrollIndex.Add(new Scroll("Dancing Lights", 0, new List<string> { "Bard", "Sorcerer", "Wizard" }));
            ScrollIndex.Add(new Scroll("Darkness", 2, new List<string> { "Sorcerer", "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Darkvision", 2, new List<string> { "Darkvision", "Ranger", "Sorcerer", "Wizard" }));
            ScrollIndex.Add(new Scroll("Daylight", 3, new List<string> { "Cleric", "Druid", "Paladin", "Ranger", "Sorcerer" }));
            ScrollIndex.Add(new Scroll("Death Ward", 4, new List<string> { "Cleric", "Paladin" }));
            ScrollIndex.Add(new Scroll("Delayed Blast Fireball", 7, new List<string> { "Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Demiplane", 8, new List<string> { "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Destructive Wave", 5, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Detect Evil and Good", 1, new List<string> { "Cleric", "Paladin" }));
            ScrollIndex.Add(new Scroll("Detect Magic", 1, new List<string> { "Bard", "Cleric", "Druid", "Paladin", "Ranger",
                                                                                "Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Detect Poison and Disease", 1, new List<string> { "Cleric", "Druid", "Paladin", "Ranger" }));
            ScrollIndex.Add(new Scroll("Detect Thoughts", 2, new List<string> { "Bard", "Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Dimension Door", 4, new List<string> {"Bard", "Sorcerer", "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Disguise Self", 1, new List<string> {"Bard", "Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Disintegrate", 6, new List<string> {"Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Dispel Evil and Good", 5, new List<string> { "Cleric", "Paladin" }));
            ScrollIndex.Add(new Scroll("Dispel Magic", 3, new List<string> {"Bard", "Cleric", "Druid", "Paladin", "Sorcerer",
                                                                                "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Dissonant Whispers", 1, new List<string> {"Bard"}));
            ScrollIndex.Add(new Scroll("Divination", 4, new List<string> { "Cleric" }));
            ScrollIndex.Add(new Scroll("Divine Favor", 1, new List<string> { "Paladin" }));
            ScrollIndex.Add(new Scroll("Divine Word", 7, new List<string> { "Cleric" }));
            ScrollIndex.Add(new Scroll("Dominate Beast", 4, new List<string> { "Druid", "Sorcerer" }));
            ScrollIndex.Add(new Scroll("Dominate Monster", 8, new List<string> {"Bard", "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Dominate Person", 5, new List<string> {"Bard", "Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Drawmij's Instant Summons", 6, new List<string> { "Wizard" }));
            ScrollIndex.Add(new Scroll("Dream", 5, new List<string> {"Bard", "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Druidcraft", 0, new List<string> {"Druid"}));
            ScrollIndex.Add(new Scroll("Earthquake", 8, new List<string> {"Cleric", "Druid", "Sorcerer"}));
            ScrollIndex.Add(new Scroll("Eldritch Blast", 0, new List<string> {"Warlock"}));
            ScrollIndex.Add(new Scroll("Elemental Weapon", 3, new List<string> {"Paladin"}));
            ScrollIndex.Add(new Scroll("Enhance Ability", 2, new List<string> {"Bard", "Cleric", "Druid", "Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Enlarge/Reduce", 2, new List<string> {"Sorcerer", "Wizard"}));
            ScrollIndex.Add(new Scroll("Ensnaring Strike", 1, new List<string> {"Ranger"}));
            ScrollIndex.Add(new Scroll("Entangle", 1, new List<string> {"Druid"}));
            ScrollIndex.Add(new Scroll("Enthrall", 2, new List<string> {"Bard", "Warlock"}));
            ScrollIndex.Add(new Scroll("Etherealness", 7, new List<string> {"Bard", "Cleric", "Sorcerer", "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Evard's Black Tentacles", 4, new List<string> {"Wizard"}));
            ScrollIndex.Add(new Scroll("Expeditious Retreat", 1, new List<string> {"Sorcerer", "Warlock", "Wizard"}));
            ScrollIndex.Add(new Scroll("Eyebite", 6, new List<string> {"Bard", "Sorcerer", "Warlock", "Wizard"}));
        }

        // A list of all gemstones and art objects available to the loot generator.
        List<Valuable> ValuablesIndex = new List<Valuable>();

        // This method adds all gemstones and art objects from the Dungeon Master's Guide
        private void standardValuablesList()
        {
            ValuablesIndex.Add(new Valuable("Azurite", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Banded Agate", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Blue Quartz", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Eye Agate", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Hematite", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Lapis Lazuli", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Malachite", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Moss Agate", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Obsidian", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Rhodochrosite", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Tiger Eye", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Turquoise", "Gemstone", 10));
            ValuablesIndex.Add(new Valuable("Bloodstone", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Amethyst", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Chrysoberyl", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Coral", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Garnet", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Jade", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Jet", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Pearl", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Spinel", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Tourmaline", "Gemstone", 50));
            ValuablesIndex.Add(new Valuable("Alexandrite", "Gemstone", 500));
            ValuablesIndex.Add(new Valuable("Aquamarine", "Gemstone", 500));
            ValuablesIndex.Add(new Valuable("Black Pearl", "Gemstone", 500));
            ValuablesIndex.Add(new Valuable("Blue Spinel", "Gemstone", 500));
            ValuablesIndex.Add(new Valuable("Peridot", "Gemstone", 500));
            ValuablesIndex.Add(new Valuable("Topaz", "Gemstone", 500));
            ValuablesIndex.Add(new Valuable("Black Opal", "Gemstone", 1000));
            ValuablesIndex.Add(new Valuable("Blue Sapphire", "Gemstone", 1000));
            ValuablesIndex.Add(new Valuable("Emerald", "Gemstone", 1000));
            ValuablesIndex.Add(new Valuable("Fire Opal", "Gemstone", 1000));
            ValuablesIndex.Add(new Valuable("Opal", "Gemstone", 1000));
            ValuablesIndex.Add(new Valuable("Star Ruby", "Gemstone", 1000));
            ValuablesIndex.Add(new Valuable("Star Sapphire", "Gemstone", 1000));
            ValuablesIndex.Add(new Valuable("Yellow Sapphire", "Gemstone", 1000));
            ValuablesIndex.Add(new Valuable("Black Sapphire", "Gemstone", 5000));
            ValuablesIndex.Add(new Valuable("Diamond", "Gemstone", 5000));
            ValuablesIndex.Add(new Valuable("Jacinth", "Gemstone", 5000));
            ValuablesIndex.Add(new Valuable("Ruby", "Gemstone", 5000));
            ValuablesIndex.Add(new Valuable("Silver Ewer", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Carved Bone Statuette", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Small Gold Bracelet", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Cloth-of-gold Vestments", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Black Velvet Mask Stitched with Silver Thread", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Copper Chalice with Silver Filigree", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Pair of Engraved Bone Dice", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Small Mirror in a Painted Wooden Frame", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Embroidered Silk Handkerchief", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Gold Locket with Painted Portrait", "Art Object", 25));
            ValuablesIndex.Add(new Valuable("Gold Ring with Bloodstones", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Carved Ivory Statuette", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Large Gold Bracelet", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Silver Necklace with Gemstone Pendant", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Bronze Crown", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Silk Robe with Gold Embroidery", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Large, Well-made Tapestry", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Brass Mug with Jade Inlay", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Box of Turquoise Animal Figures", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Gold Bird Cage with Electrum Filigree", "Art Object", 250));
            ValuablesIndex.Add(new Valuable("Silver Chalice with Moonstones", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Silvered Longsword with Jet in Hilt", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Carved Harp of Exotic Wood with Ivory and Zircon", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Small Gold Idol", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Gold Dragon Comb with Red Garnets as Eyes", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Bottle Stopper Embossed with Gold Leaf and Set with Amethysts", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Ceremonial Electrum Dagger with Black Pearl in Pommel", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Silver and Gold Brooch", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Obsidian Statuette with Gold Fittings and Inlay", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Painted Gold War Mask", "Art Object", 750));
            ValuablesIndex.Add(new Valuable("Fine Gold Chain set with a Fire Opal", "Art Object", 2500));
            ValuablesIndex.Add(new Valuable("Old Masterpiece Painting", "Art Object", 2500));
            ValuablesIndex.Add(new Valuable("Embroidered Silk and Velvet Mantle with Moonstones", "Art Object", 2500));
            ValuablesIndex.Add(new Valuable("Platinum Bracelet with a Sapphire", "Art Object", 2500));
            ValuablesIndex.Add(new Valuable("Embroidered Glove set with Jewel Chips", "Art Object", 2500));
            ValuablesIndex.Add(new Valuable("Gold Music Box", "Art Object", 2500));
            ValuablesIndex.Add(new Valuable("Gold Circlet set with Four Aquamarines", "Art Object", 2500));
            ValuablesIndex.Add(new Valuable("Eye Patch with a Mock Eye of Sapphire and Moonstone", "Art Object", 2500));
            ValuablesIndex.Add(new Valuable("Necklace String of Small Pink Pearls", "Art Object", 2500));
            ValuablesIndex.Add(new Valuable("Jeweled Gold Crown", "Art Object", 7500));
            ValuablesIndex.Add(new Valuable("Jeweled Platinum Ring", "Art Object", 7500));
            ValuablesIndex.Add(new Valuable("Jeweled Gold Crown", "Art Object", 7500));
            ValuablesIndex.Add(new Valuable("Gold Cup set with Emeralds", "Art Object", 7500));
            ValuablesIndex.Add(new Valuable("Gold Jewelry Box with Platinum Filigree", "Art Object", 7500));
            ValuablesIndex.Add(new Valuable("Painted Gold Child's Sarcophagus", "Art Object", 7500));
            ValuablesIndex.Add(new Valuable("Jade Game Board with Gold Playing Pieces", "Art Object", 7500));
            ValuablesIndex.Add(new Valuable("Bejeweled Ivory Drinking Horn with Gold Filigree", "Art Object", 7500));
        }

        // Form Constructor
        public Form1()
        {
            standardValuablesList();  // Load the gemstones/art objects from the Dungeon Master's Guide.
            standardScrollList();  // Load the spell scrolls from the Player's Handbook.
            //TODO: Load the spell scrolls from Xanathar's Guide to Everything.
            //TODO: Load the magic items from the Dungeon Master's Guide.

            // TEST: Generate a list of item names from ValuablesIndex and ScrollIndex, and add them to lstTreasure.
            List<string> itemOutput = new List<string>();
            foreach (Valuable item in ValuablesIndex)
                itemOutput.Add(item.GetName());
            foreach (Scroll item in ScrollIndex)
                itemOutput.Add(item.GetName());
            
            InitializeComponent();
            cmbHoardCR.SelectedIndex = 0;  // Set the initial Selected index for the Hoard CR combobox.
            lstTreasure.DataSource = itemOutput;
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

        // When a member of lstTreasure is selected, search the item lists for that item, and then
        //  output the item's description to txtInspect.
        private void lstTreasure_SelectedIndexChanged(object sender, EventArgs e)
        {
            string teststring = Convert.ToString(lstTreasure.SelectedItem);

            // Check gemstones and art objects.
            foreach (Valuable item in ValuablesIndex)
            {
                if (item.CheckName(teststring))
                {
                    txtInspect.Text = item.Inspect();
                    return;
                }
            }
            // Check spell scrolls.
            foreach (Scroll scroll in ScrollIndex)
            {
                if (scroll.CheckName(teststring))
                {
                    txtInspect.Text = scroll.Inspect();
                    return;
                }
            }
            // TODO: Check magic items.
        }
    }
}
