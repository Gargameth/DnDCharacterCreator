using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using DnDCharacterGenerator.Model;
using DnDCharacterGenerator.View;

namespace DnDCharacterGenerator.Controller
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Printer printer = new Printer();
            printer.PrintGreetings();
            printer.PrintRaceOptions();

            CharacterRacePrinter characterRacePrinter = new CharacterRacePrinter();
            CharacterRace characterRace = new CharacterRace(characterRacePrinter);

            Console.Clear();
            Console.WriteLine($"\n You picked the race: {characterRace.ReturnRace()} \n");
            CharacterAttributes characterAttributes = new CharacterAttributes(characterRace.ReturnRace());
            Dictionary<string, int> attributesCollection = characterAttributes.ReturnAttributes();

            printer.PrintClassOptions();

            var classInput = Console.ReadLine();
            int classNumber = 0;

            while (classNumber < 1 || classNumber > 12)
            {
                if (!int.TryParse(classInput, out classNumber) || classNumber < 1 || classNumber > 12)
                {
                    Console.WriteLine("\nI understand that adding one more number to the pressing options is complicated, but I have faith in you. So try your best in picking a damn number between 1 and 12.");
                    classInput = Console.ReadLine();
                }
            }

            CharacterClassPrinter charClassPrinter = new CharacterClassPrinter();
            CharacterClass characterClass = new CharacterClass(classNumber, charClassPrinter);
            string returnClass = characterClass.ReturnCharacterClass();
            Dictionary<string, int> abilityModifiers = characterAttributes.ReturnAttributeModifiers();
            CharacterHealth characterHealth = new CharacterHealth(characterClass.ReturnCharacterClass(), abilityModifiers["Constitution"]);
            CharacterHealthPrinter healthPrinter = new CharacterHealthPrinter();
            Console.Clear();

            Backgrounds backgrounds = new Backgrounds();
            printer.PrintBackgrounds(backgrounds);

            int backgroundNumber = 0;
            var backgroundInput = Console.ReadLine();

            while (backgroundNumber < 1 || backgroundNumber > 34)
            {
                if (!int.TryParse(backgroundInput, out backgroundNumber) || backgroundNumber < 1 || backgroundNumber > 34)
                {
                    Console.WriteLine("\nI understand that adding increasing the number you need to press is complicated, but I have faith in you. So try your best in picking a damn number between 1 and 33.");
                    backgroundInput = Console.ReadLine();
                }
            }

            backgrounds.SetBackground(backgroundNumber - 1);
            Skills skills = new Skills();
            skills.AddSkills(backgrounds.ReturnPlayersBackgroundsCollection().First().Value);

            Console.WriteLine($"\n You picked the class: {characterClass.ReturnCharacterClass()} \n");
            healthPrinter.PrintHealthOfCharacter(characterHealth);
            Console.WriteLine($"Your character's hit die type is D{characterHealth.ReturnHitDie().First().Key}. The amount of hit dice you have is: {characterHealth.ReturnHitDie().First().Value}\n");
            Console.WriteLine($"Your character's background is: {backgrounds.ReturnPlayersBackgroundsCollection().First().Key}");
            Console.WriteLine($"Your character's starting skills are: ");
            List<string> listOfBackgroundSkills = skills.ReturnSkills();
            foreach (var value in listOfBackgroundSkills)
            {
                Console.WriteLine(value);
            }

            CharacterAttributePrinter attributePrinter = new CharacterAttributePrinter();
            attributePrinter.PrintAttributes(attributesCollection);
        }
    }
}