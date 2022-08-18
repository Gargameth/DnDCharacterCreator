using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    internal class CharacterClass
    {
        private string characterClass;

        public CharacterClass(int charactersClass)
        {
            switch (charactersClass)
            {
                case 1:
                    characterClass = "Barbarian";
                    break;

                case 2:
                    characterClass = "Bard";
                    break;

                case 3:
                    characterClass = "Cleric";
                    break;

                case 4:
                    characterClass = "Druid";
                    break;

                case 5:
                    characterClass = "Fighter";
                    break;

                case 6:
                    characterClass = "Monk";
                    break;

                case 7:
                    characterClass = "Paladin";
                    break;

                case 8:
                    characterClass = "Ranger";
                    break;

                case 9:
                    characterClass = "Rogue";
                    break;

                case 10:
                    characterClass = "Sorcerer";
                    break;

                case 11:
                    characterClass = "Warlock";
                    break;

                case 12:
                    characterClass = "Wizard";
                    break;
            }
        }

        public string ReturnCharacterClass()
        {
            return characterClass;
        }
    }
}
