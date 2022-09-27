using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class SkillsPrinter : BasePrinter
    {
        public SkillsPrinter()
        {
        }

        public void SkillAlreadyInTheListWarning(string skill)
        {
            Console.WriteLine($"The skill {skill} is already in your list.");
        }

        public void PrintSkills(List<string> skills)
        {
            Console.WriteLine($"Your character's starting skills are: \n");
            foreach (var value in skills)
            {
                Console.WriteLine(value);
            }
        }
    }
}
