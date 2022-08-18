using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    internal class CharacterRace
    {
        private string _race;

        public CharacterRace(int race)
        {
            switch (race)
            {
                case 1:
                    _race = "Human";
                    break;
                
                case 2:
                    _race = "Dwarf";
                    break;

                case 3:
                    _race = "Elf";
                    break;

                case 4:
                    _race = "Halfling";
                    break;

                case 5:
                    _race = "Dragonborn";
                    break;

                case 6:
                    _race = "Half-elf";
                    break;

                case 7:
                    _race = "Half-orc";
                    break;

                case 8:
                    _race = "Thiefling";
                    break;

                case 9:
                    _race = "Gnome";
                    break;
            }
        }

        public string ReturnRace()
        {
            return _race;
        }
    }
}
