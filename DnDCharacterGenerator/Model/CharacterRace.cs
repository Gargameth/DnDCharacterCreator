using DnDCharacterGenerator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.Model
{
    internal class CharacterRace
    {
        private string _race;

        public CharacterRace(CharacterRacePrinter printer)
        {
            switch (RaceChooser(printer))
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

        private int RaceChooser(CharacterRacePrinter printer)
        {
            printer.PrintRaceOptions();
            var chosenRace = printer.ReadInput();
            int raceNumber = 0;
            while (raceNumber < 1 || raceNumber > 9)
            {
                if (!int.TryParse(chosenRace, out raceNumber) || raceNumber < 1 || raceNumber > 9)
                {
                    printer.InvalidInputWarning();
                    chosenRace = printer.ReadInput();
                }
            }
            return raceNumber;
        }


        public string ReturnRace()
        {
            return _race;
        }
    }
}
