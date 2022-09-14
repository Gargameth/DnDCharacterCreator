using DnDCharacterGenerator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    internal class Skills
    {
        private List<string> _skillsFromBackground = new List<string>();
        private List<string> _skillsFromClass = new List<string>();

        public Skills()
        {
        }

        public void AddSkillsFromBackground(List<string> skills)
        {
            foreach (var skill in skills)
            {
                _skillsFromBackground.Add(skill);
            }
        }

        public List<string> ReturnSkillsFromBackground()
        {
            return _skillsFromBackground;
        }
    }
}
