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

        public void PrintInvalidRaceInputText()
        {
            Console.WriteLine("\n Why is picking a number from 1 to 9 that difficult?");
        }

        public void PrintCharacterRace(CharacterRace characterRace)
        {
            Console.Clear();
            Console.WriteLine($"\n You picked the race: {characterRace.ReturnRace()} \n");
        }
    }
}
