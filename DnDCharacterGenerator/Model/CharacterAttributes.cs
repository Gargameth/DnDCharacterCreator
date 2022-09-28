using DnDCharacterGenerator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    internal class CharacterAttributes
    {
        /// <summary>
        /// Create a dictionary of attributes, and fill them with random values up to 18, and adding
        /// bonus according to race. An attribute can not be higher than 20 this way.
        /// </summary>
        private Dictionary<string, int> attributes = new Dictionary<string, int>();
        private Dictionary<string, int> attributeModifiers = new Dictionary<string, int>();
        private List<int> rawAttributeScores = new List<int>();
        private List<string> attributeScores = new List<string>() { "Strength", "Dexterity", "Constitution", "Intelligence", "Wisdom", "Charisma"};

        public CharacterAttributes(string race, CharacterAttributePrinter printer)
        {
            RollAttributeDice();
            AssignScoresToAttribute(printer);
            AddRaceBonus(race, printer);
            SetModifiers();
            printer.PrintAttributes(attributes);
        }

        private void AssignScoresToAttribute(CharacterAttributePrinter printer)
        {
            for (int i = 0; i < 6; i++)
            {
                attributes[attributeScores[i]] = 0;
            }

            List<string> dummyAttributeScores = attributeScores.ToList();
            
            while (rawAttributeScores.Count() > 0)
            {
                printer.PrintAbilityScores(rawAttributeScores);
                printer.AskForAttribute(dummyAttributeScores[0]);
                var input = printer.ReadInput();
                int abilityScore = 0;
                if (!int.TryParse(input, out abilityScore) || rawAttributeScores.IndexOf(abilityScore) == -1)
                {
                    printer.InvalidInputWarning();
                    Console.ReadLine();
                }
                else
                {
                    attributes[dummyAttributeScores[0]] = abilityScore;
                    rawAttributeScores.Remove(abilityScore);
                    dummyAttributeScores.Remove(dummyAttributeScores[0]);
                    printer.ClearConsole();
                }
            }
        }

        private int CalculateModifiers(int attributeScore)
        {
            int modifier = 0;
            switch (attributeScore)
            {
                case 3:
                    modifier = -4;
                    break;

                case 4:
                case 5:
                    modifier = -3;
                    break;

                case 6:
                case 7:
                    modifier = -2;
                    break;

                case 8:
                case 9:
                    modifier = -1;
                    break;

                case 10:
                case 11:
                    modifier = 0;
                    break;

                case 12:
                case 13:
                    modifier = 1;
                    break;

                case 14:
                case 15:
                    modifier = 2;
                    break;
                
                case 16:
                case 17:
                    modifier = 3;
                    break;
                
                case 18:
                case 19:
                    modifier = 4;
                    break;
                    
                case 20:
                    modifier = 5;
                    break;
            }

            return modifier;
        }

        /// <summary>
        /// This method fills up the attribute modifier dictionary with keys from the attributes dictionary
        /// and then calculates the modifier as value, using the mentioned method.
        /// </summary>
        private void SetModifiers()
        {
            foreach (var attribute in attributes)
            {
                attributeModifiers.Add(attribute.Key, CalculateModifiers(attribute.Value));
            }
        }

        private void RollAttributeDice()
        {
            Random random = new Random();
            for (int i = 0; i < 6; i++)
            {
                List<int> Rolls = new List<int>();
                for (int j = 0; j < 4; j++)
                {
                    Rolls.Add(random.Next(1, 7));
                }
                Rolls.Sort();
                Rolls.Remove(Rolls[0]);
                int rawAbilityScore = Rolls.Take(3).Sum();
                rawAttributeScores.Add(rawAbilityScore);
            }
        }

        private void ChooseAttributesToIncreaseAsBonus(CharacterAttributePrinter printer)
        {
            List<string> bonus = new List<string>(attributeScores);
            while (bonus.Count > 4)
            {
                if (bonus.Count == 6)
                {
                    printer.AskForFirstAttributeForRaceBonus();
                }
                else
                {
                    printer.AskForSecondAttributeForRaceBonus();
                }

                var input = printer.ReadInput();

                if (!bonus.Contains(input))
                {
                    printer.InvalidInputWarning();
                }
                else
                {
                    bonus.Remove(input);
                    attributes[input]++;
                    printer.ClearConsole();
                }
            }
        }

        private void AddRaceBonus(string characterRace, CharacterAttributePrinter printer)
        {
            switch (characterRace)
            {
                ///Copy attributes dictionary, then pick one key randomly from the copy, then increase
                ///the int on the original one according to the copy's key. It there is no random picking of 
                ///attributes, simply increase the appropriate attribute in the original dictionary.
                case "Human":
                    ChooseAttributesToIncreaseAsBonus(printer);
                    break;

                case "Dwarf":
                    attributes["Constitution"] += 2;
                    break;

                case "Elf":
                    attributes["Dexterity"] += 2;
                    break;

                case "Dragonborn":
                    attributes["Strength"] += 2;
                    attributes["Charisma"] += 1;
                    break;

                case "Thiefling":
                    attributes["Charisma"] += 2;
                    break;

                case "Halfling":
                    attributes["Dexterity"] += 2;
                    break;

                case "Half-elf":
                    attributes["Charisma"] += 2;
                    ChooseAttributesToIncreaseAsBonus(printer);
                    break;

                case "Half-orc":
                    attributes["Strength"] += 2;
                    attributes["Constitution"] += 1;
                    break;

                case "Gnome":
                    attributes["Intelligence"] += 2;
                    break;
            }
        }

        public Dictionary<string, int> ReturnAttributes()
        {
            return attributes;
        }

        public Dictionary<string, int> ReturnAttributeModifiers()
        {
            return attributeModifiers;
        }
    }
}
