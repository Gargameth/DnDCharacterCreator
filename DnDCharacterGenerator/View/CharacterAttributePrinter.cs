using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal class CharacterAttributePrinter
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
    }
}
