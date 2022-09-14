using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDCharacterGenerator.Model;

namespace DnDCharacterGenerator.View
{
    internal class Printer
    {
        public Printer()
        {
        }

        public void PrintGreetings()
        {
            Console.WriteLine("Welcome to a rudimentary D&D character creator.");
            Console.WriteLine("For now you can only create a character with random attribute scores.");
            Console.WriteLine("It will get better, trust me. We have the technology. The skills are not here yet, but are on their way.");
        }

        public void PrintRaceOptions()
        {
            Console.WriteLine("Please choose the race of your character (pick a number).\n");
            Console.WriteLine("1. Human");
            Console.WriteLine("2. Dwarf");
            Console.WriteLine("3. Elf");
            Console.WriteLine("4. Halfling");
            Console.WriteLine("5. Dragonborn");
            Console.WriteLine("6. Half-elf");
            Console.WriteLine("7. Half-orc");
            Console.WriteLine("8. Thiefling");
            Console.WriteLine("9. Gnome");
        }

        public void PrintClassOptions()
        {
            Console.WriteLine("Please choose the class of your character (pick another number; I know, it's complicated).\n");
            Console.WriteLine("1. Barbarian");
            Console.WriteLine("2. Bard");
            Console.WriteLine("3. Cleric");
            Console.WriteLine("4. Druid");
            Console.WriteLine("5. Fighter");
            Console.WriteLine("6. Monk");
            Console.WriteLine("7. Paladin");
            Console.WriteLine("8. Ranger");
            Console.WriteLine("9. Rogue");
            Console.WriteLine("10. Sorcerer");
            Console.WriteLine("11. Warlock");
            Console.WriteLine("12. Wizard\n");
        }

        public void PrintBackgrounds(Backgrounds backgrounds)
        {
            Console.WriteLine("Pick a background for your character (yes, another number's game):\n");
            Dictionary<string, List<string>> backgroundCollection = backgrounds.ReturnBackgroundsCollection();

            int indexerForBackgrounds = 1;
            foreach (KeyValuePair<string, List<string>> backGrounds in backgroundCollection)
            {
                Console.WriteLine($"{indexerForBackgrounds}:" + " " + backGrounds.Key);
                indexerForBackgrounds++;
            }
        }
    }
}
