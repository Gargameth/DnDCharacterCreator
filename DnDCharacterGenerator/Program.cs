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
            Printer printer = new Printer();
            printer.PrintGreetings();
            printer.PrintRaceOptions();
            
            var raceInput = Console.ReadLine();
            int raceNumber = 0;
            while (raceNumber < 1 || raceNumber > 9)
            {
                if (!Int32.TryParse(raceInput, out raceNumber) || raceNumber < 1 || raceNumber > 9)
                {
                    Console.WriteLine("\nWhy is picking a number from 1 to 9 that difficult?");
                    raceInput = Console.ReadLine();
                }
            }
            CharacterRace characterRace = new CharacterRace(raceNumber);
            
            Console.Clear();
            Console.WriteLine($"\n You picked the race: {characterRace.ReturnRace()} \n");
            CharacterAttributes characterAttributes = new CharacterAttributes(Int32.Parse(raceInput));
            Dictionary<string, int> attributesCollection = characterAttributes.ReturnAttributes();

            printer.PrintClassOptions();
            
            var classInput = Console.ReadLine();
            int classNumber = 0;
            
            while (classNumber < 1 || classNumber > 12)
            {
                if (!Int32.TryParse(classInput, out classNumber) || classNumber < 1 || classNumber > 12)
                {
                    Console.WriteLine("\nI understand that adding one more number to the pressing options is complicated, but I have faith in you. So try your best in picking a damn number between 1 and 12.");
                    classInput = Console.ReadLine();
                }
            }

            CharacterClass characterClass = new CharacterClass(classNumber);
            string returnClass = characterClass.ReturnCharacterClass();
            Dictionary<string, int> abilityModifiers = characterAttributes.ReturnAttributeModifiers();
            CharacterHealth characterHealth = new CharacterHealth(characterClass.ReturnCharacterClass(), abilityModifiers["Constitution"]);
            Console.Clear();

            Backgrounds backgrounds = new Backgrounds();
            printer.PrintBackgrounds(backgrounds);

            int backgroundNumber = 0;
            var backgroundInput = Console.ReadLine();

            while (backgroundNumber < 1 || backgroundNumber > 34)
            {
                if (!Int32.TryParse(backgroundInput, out backgroundNumber) || backgroundNumber < 1 || backgroundNumber > 34)
                {
                    Console.WriteLine("\nI understand that adding one more number to the pressing options is complicated, but I have faith in you. So try your best in picking a damn number between 1 and 12.");
                    backgroundInput = Console.ReadLine();
                }
            }

            backgrounds.SetBackground(backgroundNumber - 1);

            Console.WriteLine($"\n You picked the class: {characterClass.ReturnCharacterClass()} \n");
            Console.WriteLine($"Your character's health is: {characterHealth.ReturnHealth()}\n");
            Console.WriteLine($"Your character's hit die type is D{characterHealth.ReturnHitDie().First().Key}. The amount of hit dice you have is: {characterHealth.ReturnHitDie().First().Value}\n");
            Console.WriteLine($"Your character's background is: {backgrounds.ReturnPlayersBackgroundsCollection().First().Key}");
            Console.WriteLine($"Your character's starting skills are: ");
            List<string> listOfBackgroundSkills = backgrounds.ReturnPlayersBackgroundsCollection().First().Value;
            foreach (var value in listOfBackgroundSkills)
            {
                Console.WriteLine(value);
            }
            

            Console.WriteLine("\nYour character's ability scores are:\n");
            foreach (var attribute in attributesCollection)
            {
                Console.WriteLine(attribute.Key + " " + attribute.Value);
            }
        }
    }
}