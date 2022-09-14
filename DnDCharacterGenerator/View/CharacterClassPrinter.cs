using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class CharacterClassPrinter
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

        public string? ReadInput()
        {
            string input = Console.ReadLine();
            return input;
        }

        public void InvalidInputWarning()
        {
            Console.WriteLine("Invalid input. Please try again.");
        }

        public void ClearConsole()
        {
            Console.Clear();
        }
    }
}
