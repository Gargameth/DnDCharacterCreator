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

        

        
    }
}
