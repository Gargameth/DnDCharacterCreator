using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class CharacterRacePrinter
    {
        public CharacterRacePrinter()
        {
        }

        public string GetInput()
        {
            var input = Console.ReadLine();
            return input;
        }

        public void PrintInvalidRaceInputText()
        {
            Console.WriteLine("\n Why is picking a number from 1 to 9 that difficult?");
        }
    }
}
