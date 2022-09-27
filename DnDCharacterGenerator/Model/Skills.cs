using DnDCharacterGenerator.Model;
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
        private List<string> _skillsList = new List<string>();

        public Skills(CharacterClass characterClass)
        {
            _skillsList = characterClass.ReturnClassSkills();
        }

        public void AddSkillsFromBackground(List<string> skills)
        {
            foreach (var skill in skills)
            {
                if (_skillsList.Contains(skill))
                {
                    continue;
                }
                else { _skillsList.Add(skill); }
            }
        }

        public List<string> ReturnSkills()
        {
            return _skillsList;
        }
    }
}
