using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class CharacterAttributePrinter : BasePrinter
    {
        public CharacterAttributePrinter()
        {
        }

        public void PrintAttributes(Dictionary<string, int> attributesCollection)
        {
            Console.WriteLine("\nYour character's ability scores are:\n");
            foreach (var attribute in attributesCollection)
            {
                Console.WriteLine(attribute.Key + " " + attribute.Value);
            }
        }

        public void AskForAttribute(string attributeScore)
        {
            Console.WriteLine($"Assign a score to {attributeScore}.");
        }

        public void PrintAbilityScores(List<int> scores)
        {
            foreach(int score in scores)
            {
                Console.WriteLine(score);
            }
        }

        public void AskForFirstAttributeForRaceBonus()
        {
            Console.WriteLine("Enter the first attribute you want to increase.");
        }

        public void AskForSecondAttributeForRaceBonus()
        {
            Console.WriteLine("Enter the second attribute you want to increase.");
        }
    }
}
