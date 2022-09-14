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
        private List<string> _skills = new List<string>();

        public Skills()
        {
        }

        public void AddSkills(List<string> skills)
        {
            foreach (var skill in skills)
            {
                if (_skills.Contains(skill))
                {
                    continue;
                }
                else
                {
                    _skills.Add(skill);
                }
            }
        }

        public List<string> ReturnSkills()
        {
            return _skills;
        }
    }
}
