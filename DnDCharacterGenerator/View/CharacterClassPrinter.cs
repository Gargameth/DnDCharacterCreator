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

        public void PrintClassChoice(CharacterClass characterClass)
        {
            Console.WriteLine($"\n You picked the class: {characterClass.ReturnCharacterClass()} \n");
        }
    }
}
