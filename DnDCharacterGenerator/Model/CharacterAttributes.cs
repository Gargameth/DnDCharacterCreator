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


        public CharacterAttributes(string race)
        {
            attributes.Add("Strength", RollAttributeDice());
            attributes.Add("Dexterity", RollAttributeDice());
            attributes.Add("Constitution", RollAttributeDice());
            attributes.Add("Intelligence", RollAttributeDice());
            attributes.Add("Wisdom", RollAttributeDice());
            attributes.Add("Charisma", RollAttributeDice());
            AddRaceBonus(race);
            SetModifiers();
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

        private int RollAttributeDice()
        {
            List<int> Rolls = new List<int>();
            Random random = new Random();
            int attribute = 0;
            for (int i = 0; i < 4; i++)
            {
                Rolls.Add(random.Next(1,6));
            }

            Rolls.Sort();
            Rolls.Remove(Rolls[0]);
            for (int i = 0; i < Rolls.Count; i++)
            {
                attribute += Rolls[i];
            }
            return attribute;
        }

        private void AddRaceBonus(string characterRace)
        {
            Random random = new Random();
            switch (characterRace)
            {
                ///Copy attributes dictionary, then pick one key randomly from the copy, then increase
                ///the int on the original one according to the copy's key. It there is no random picking of 
                ///attributes, simply increase the appropriate attribute in the original dictionary.
                case "Human":
                    Dictionary<string,int> humanBonus = new Dictionary<string,int>(attributes);
                    int firstRandomPickHuman = random.Next(0, humanBonus.Count());
                    string firstIncreasedAbilityScoreHuman = humanBonus.ElementAt(firstRandomPickHuman).Key;
                    attributes[firstIncreasedAbilityScoreHuman] += 1;
                    humanBonus.Remove(firstIncreasedAbilityScoreHuman);
                    int secondRandomPickHuman = random.Next(0, humanBonus.Count());
                    string secondIncreasedAbilityScoreHuman = humanBonus.ElementAt(secondRandomPickHuman).Key;
                    attributes[secondIncreasedAbilityScoreHuman] += 1;
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
                    Dictionary<string, int> halfElfBonus = new Dictionary<string, int>(attributes);
                    halfElfBonus.Remove("Charisma");
                    int firstRandomPickHalfElf = random.Next(0, halfElfBonus.Count());
                    string firstIncreasedAbilityScoreHalfElf = halfElfBonus.ElementAt(firstRandomPickHalfElf).Key;
                    attributes[firstIncreasedAbilityScoreHalfElf] += 1;
                    halfElfBonus.Remove(firstIncreasedAbilityScoreHalfElf);
                    int secondRandomPickHalfElf = random.Next(0, halfElfBonus.Count());
                    string secondIncreasedAbilityScoreHalfElf = halfElfBonus.ElementAt(secondRandomPickHalfElf).Key;
                    attributes[secondIncreasedAbilityScoreHalfElf] += 1;
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
