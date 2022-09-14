using DnDCharacterGenerator.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class CharacterBackgroundsPrinter : BasePrinter
    {
        public CharacterBackgroundsPrinter()
        {
        }

        public void PrintBackgrounds(Backgrounds backgrounds)
        {
            ClearConsole();
            Console.WriteLine("Pick a background for your character (yes, another number's game):\n");
            Dictionary<string, List<string>> backgroundCollection = backgrounds.ReturnBackgroundsCollection();

            int indexerForBackgrounds = 1;
            foreach (KeyValuePair<string, List<string>> backGrounds in backgroundCollection)
            {
                Console.WriteLine($"{indexerForBackgrounds}:" + " " + backGrounds.Key);
                indexerForBackgrounds++;
            }
        }

        public void PrintChosenBackground(Backgrounds background)
        {
            Console.WriteLine($"Your character's background is: {background.ReturnPlayersBackgroundsCollection().First().Key}");
        }
    }
}
