using DnDCharacterGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class CharacterHealthPrinter : BasePrinter
    {
        public CharacterHealthPrinter()
        {
        }

        public void PrintHealthOfCharacter(CharacterHealth health)
        {
            Console.WriteLine($"Your character's health is: {health.ReturnHealth()}\n");
        }

        public void PrintHitDieOfCharacter(CharacterHealth health)
        {
            Console.WriteLine($"Your character's hit die type is D{health.ReturnHitDie().First().Key}. The amount of hit dice you have is: {health.ReturnHitDie().First().Value}\n");
        }
    }
}
