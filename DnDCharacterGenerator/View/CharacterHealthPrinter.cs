using DnDCharacterGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class CharacterHealthPrinter
    {
        public CharacterHealthPrinter()
        {
        }

        public void PrintHealthOfCharacter(CharacterHealth health)
        {
            Console.WriteLine($"Your character's health is: {health.ReturnHealth()}\n");
        }
    }
}
