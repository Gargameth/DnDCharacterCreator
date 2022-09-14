using DnDCharacterGenerator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.Model
{
    internal class Backgrounds
    {
        private Dictionary<string, List<string>> _backgrounds = new Dictionary<string, List<string>>();
        private Dictionary<string, List<string>> _chosenBackgrounds = new Dictionary<string, List<string>>();

        public Backgrounds()
        {
            _backgrounds.Add("Acolyte", new List<string> { "Insight", "Religion" });
            _backgrounds.Add("Anthropologist", new List<string> { "Insight", "Religion" });
            _backgrounds.Add("Archeologist", new List<string> { "History", "Survival" });
            _backgrounds.Add("Athlete", new List<string> { "Acrobatics", "Athletics" });
            _backgrounds.Add("Charlatan", new List<string> { "Deception", "Sleight of Hand" });
            _backgrounds.Add("City Watch", new List<string> { "Athletics", "Insight" });
            _backgrounds.Add("Clan Crafter", new List<string> { "History", "Insight" });
            ///Pick one from the last three
            _backgrounds.Add("Cloistered Scholar", new List<string> { "History", "Arcana", "Nature", "Religion" });
            _backgrounds.Add("Courtier", new List<string> { "Insight", "Persuasion" });
            _backgrounds.Add("Criminal", new List<string> { "Deception", "Stealth" });
            _backgrounds.Add("Entertainer", new List<string> { "Acrobatics", "Performance" });
            _backgrounds.Add("Faceless", new List<string> { "Deception", "Intimidation" });
            ///Pick one from after insight
            _backgrounds.Add("Faction Agent", new List<string> { "Insight", "Animal Handling", "Arcana", "Deception", "History", "Intimidation", "Investigation", "Medicine", "Nature", "Perception", "Performance", "Persuasion", "Religion", "Survival" });
            _backgrounds.Add("Far Traveller", new List<string> { "Insight", "Perception" });
            _backgrounds.Add("Feylost", new List<string> { "Deception", "Survival" });
            _backgrounds.Add("Fisher", new List<string> { "History", "Survival" });
            _backgrounds.Add("Folk Hero", new List<string> { "Animal Handling", "Survival" });
            _backgrounds.Add("Guild Artisan", new List<string> { "Insight", "Persuasion" });
            ///Pick two
            _backgrounds.Add("Haunted One", new List<string> { "Arcana", "Investigation", "Religion", "Survival" });
            _backgrounds.Add("Hermit", new List<string> { "Medicine", "Religion" });
            _backgrounds.Add("House Agent", new List<string> { "Investigation", "Persuasion" });
            //Pick one after survival
            _backgrounds.Add("Inheritor", new List<string> { "Survival", "Arcana", "History", "Religion" });
            _backgrounds.Add("Noble", new List<string> { "History", "Persuasion" });
            _backgrounds.Add("Knight of the Order", new List<string> { "Persuasion", "Arcana", "History", "Nature", "Religion" });
            _backgrounds.Add("Marine", new List<string> { "Athletics", "Survival" });
            _backgrounds.Add("Mercenary Veteran", new List<string> { "Athletics", "Persuasion" });
            _backgrounds.Add("Outlander", new List<string> { "Athletics", "Survival" });
            _backgrounds.Add("Sage", new List<string> { "Arcana", "History" });
            _backgrounds.Add("Sailor", new List<string> { "Athletics", "Perception" });
            _backgrounds.Add("Shipwright", new List<string> { "History", "Perception" });
            _backgrounds.Add("Smuggler", new List<string> { "Athletics", "Deception" });
            _backgrounds.Add("Soldier", new List<string> { "Athletics", "Intimidation" });
        }

        private int SetBackgroundNumber(CharacterBackgroundsPrinter printer)
        {
            int backgroundNumber = 0;
            var backgroundInput = printer.ReadInput();

            while (backgroundNumber < 1 || backgroundNumber > 32)
            {
                if (!int.TryParse(backgroundInput, out backgroundNumber) || backgroundNumber < 1 || backgroundNumber > 32)
                {
                    printer.InvalidInputWarning();
                    backgroundInput = Console.ReadLine();
                }
            }
            return backgroundNumber - 1;
        }

        //Create a list of skills using the values of the chosen background in the background's list.
        //Fill that list up with strings, then add it to the chosen backgrounds dictionary 
        public void SetBackground(CharacterBackgroundsPrinter printer)
        {
            int backgroundsNumber = SetBackgroundNumber(printer);
            _chosenBackgrounds.Add(_backgrounds.ElementAt(backgroundsNumber).Key, _backgrounds.ElementAt(backgroundsNumber).Value);
        }

        public Dictionary<string, List<string>> ReturnBackgroundsCollection()
        {
            return _backgrounds;
        }

        public Dictionary<string, List<string>> ReturnPlayersBackgroundsCollection()
        {
            return _chosenBackgrounds;
        }
    }
}
