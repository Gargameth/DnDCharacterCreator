using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class SkillsPrinter
    {
        public SkillsPrinter()
        {
        }

        public void SkillAlreadyInTheListWarning(string skill)
        {
            Console.WriteLine($"The skill {skill} is already in your list.");
        }
    }
}
