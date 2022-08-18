using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to a rudimentary D&D character creator.");
            Console.WriteLine("For now you can only create a character with random attribute scores.");
            Console.WriteLine("It will get better, trust me. We have the technology. The skills are not here yet, but are on their way.");
            Console.WriteLine("Please choose the race of your character (pick a number).\n");
            Console.WriteLine("1. Human");
            Console.WriteLine("2. Dwarf");
            Console.WriteLine("3. Elf");
            Console.WriteLine("4. Halfling");
            Console.WriteLine("5. Dragonborn");
            Console.WriteLine("6. Half-elf");
            Console.WriteLine("7. Half-orc");
            Console.WriteLine("8. Thiefling");
            Console.WriteLine("9. Gnome");
            
            var raceInput = Console.ReadLine();
            while (!Regex.Match(raceInput, "^[1-9]$").Success)
            {
                Console.WriteLine("\nWhy is picking a number from 1 to 9 that difficult?");
                raceInput = Console.ReadLine();
            }

            CharacterRace characterRace = new CharacterRace(Int32.Parse(raceInput));
            Console.Clear();
            Console.WriteLine($"\n You picked the race: {characterRace.ReturnRace()} \n");
            CharacterAttributes characterAttributes = new CharacterAttributes(Int32.Parse(raceInput));
            Dictionary<string, int> attributesCollection = characterAttributes.ReturnAttributes();

            Console.WriteLine("Please choose the class of your character (pick another number; I know, it's complicated).\n");
            Console.WriteLine("1. Barbarian");
            Console.WriteLine("2. Bard");
            Console.WriteLine("3. Cleric");
            Console.WriteLine("4. Druid");
            Console.WriteLine("5. Fighter");
            Console.WriteLine("6. Monk");
            Console.WriteLine("7. Paladin");
            Console.WriteLine("8. Ranger");
            Console.WriteLine("9. Rogue");
            Console.WriteLine("10. Sorcerer");
            Console.WriteLine("11. Warlock");
            Console.WriteLine("12. Wizard\n");
            
            var classInput = Console.ReadLine();
            ///Use try-parse -> faster than regex and no need to convert string to int
            
            while (!Regex.Match(classInput, "^[1-9][0-2]?$|^12").Success)
            {
                Console.WriteLine("\n I understand that adding one more number to the pressing options is complicated, but I have faith in you. So try your best in picking a damn number between 1 and 12.");
                classInput = Console.ReadLine();
            }

            CharacterClass characterClass = new CharacterClass(Int32.Parse(classInput));
            Dictionary<string, int> abilityModifiers = characterAttributes.ReturnAttributeModifiers();
            CharacterHealth characterHealth = new CharacterHealth(characterClass.ReturnCharacterClass(), abilityModifiers["Constitution"]);
            Console.Clear();

            Console.WriteLine("Pick a background for your character (yes, another number's game):");
            Backgrounds backgrounds = new Backgrounds();
            Dictionary<string, List<string>> backgroundCollection = backgrounds.ReturnBackgroundsCollection();
            int indexerForBackgrounds = 1;
            foreach (KeyValuePair<string, List<string>> backGrounds in backgroundCollection)
            {
                Console.WriteLine($"{indexerForBackgrounds}:" + " " + backGrounds.Key);
                indexerForBackgrounds++;
            }
            
            Console.ReadKey();

            Console.WriteLine($"\n You picked the class: {characterClass.ReturnCharacterClass()} \n");
            Console.WriteLine($"Your character's health is: {characterHealth.ReturnHealth()}\n");
            Console.WriteLine($"Your character's hit die type is D{characterHealth.ReturnHitDie().First().Key}. The amount of hit dice you have is: {characterHealth.ReturnHitDie().First().Value}\n");

            Console.WriteLine("\nYour character's ability scores are:\n");
            foreach (var attribute in attributesCollection)
            {
                Console.WriteLine(attribute.Key + " " + attribute.Value);
            }
        }
    }
}