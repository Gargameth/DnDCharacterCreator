using DnDCharacterGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class CharacterClassPrinter : BasePrinter
    {
        public CharacterClassPrinter()
        {
        }

        public void SetFirstClassSkillText()
        {
            Console.WriteLine("Set your first class skill (try not make typos; letters are case sensitive): \n");
        }

        public void SetSecondClassSkillText()
        {
            Console.WriteLine("Now choose your second class skill (with the above mentiones typing rules): \n");
        }

        public void SetThirdClassSkillText()
        {
            Console.WriteLine("It's amazing, but you can have a third class skill... if you can spell it correctly: \n");
        }

        public void SetFourthClassSkillText()
        {
            Console.WriteLine("This is getting annoying, I know, but I promise, this is the last skill you need to pick... honest:\n");
        }

        public void PrintSkillList(List<string> skills)
        {
            foreach (string skill in skills)
            {
                Console.WriteLine(skill);
            }
        }

        public void PrintClassOptions()
        {
            Console.WriteLine("Please choose the class of your character (pick another number; I know, it's complicated).\n");
            Console.Write("1. Barbarian | ");
            Console.Write("2. Bard | ");
            Console.Write("3. Cleric | ");
            Console.Write("4. Druid | ");
            Console.Write("5. Fighter | ");
            Console.Write("6. Monk | ");
            Console.Write("7. Paladin | ");
            Console.Write("8. Ranger | ");
            Console.Write("9. Rogue | ");
            Console.Write("10. Sorcerer | ");
            Console.Write("11. Warlock | ");
            Console.Write("12. Wizard\n");
        }

        public void PrintClassChoice(CharacterClass characterClass)
        {
            Console.WriteLine($"\n You picked the class: {characterClass.ReturnCharacterClass()} \n");
        }
    }
}
