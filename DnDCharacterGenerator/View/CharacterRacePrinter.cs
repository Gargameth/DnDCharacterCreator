using DnDCharacterGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class CharacterRacePrinter : BasePrinter
    {
        public CharacterRacePrinter()
        {
        }

        public override void InvalidInputWarning()
        {
            Console.WriteLine("\n Why is picking a number from 1 to 9 that difficult?");
        }

        public void PrintCharacterRace(CharacterRace characterRace)
        {
            Console.Clear();
            Console.WriteLine($"\n You picked the race: {characterRace.ReturnRace()} \n");
        }


        public void PrintRaceOptions()
        {
            Console.WriteLine("Please choose the race of your character (pick a number).\n");
            Console.Write("1. Human | ");
            Console.Write("2. Dwarf | ");
            Console.Write("3. Elf | ");
            Console.Write("4. Halfling | ");
            Console.Write("5. Dragonborn | ");
            Console.Write("6. Half-elf | ");
            Console.Write("7. Half-orc | ");
            Console.Write("8. Thiefling | ");
            Console.Write("9. Gnome | ");
        }
    }
}
