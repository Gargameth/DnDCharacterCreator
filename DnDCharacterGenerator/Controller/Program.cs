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

            characterRacePrinter.PrintCharacterRace(characterRace);
            
            CharacterAttributes characterAttributes = new CharacterAttributes(characterRace.ReturnRace());
            
            Dictionary<string, int> attributesCollection = characterAttributes.ReturnAttributes();

            CharacterClassPrinter characterClassPrinter = new CharacterClassPrinter();

            characterClassPrinter.PrintClassOptions();

            CharacterClass characterClass = new CharacterClass(characterClassPrinter);

            Dictionary<string, int> abilityModifiers = characterAttributes.ReturnAttributeModifiers();
            CharacterHealth characterHealth = new CharacterHealth(characterClass.ReturnCharacterClass(), abilityModifiers["Constitution"]);
            CharacterHealthPrinter healthPrinter = new CharacterHealthPrinter();

            Backgrounds backgrounds = new Backgrounds();
            CharacterBackgroundsPrinter characterBackgroundsPrinter = new CharacterBackgroundsPrinter();
            
            characterBackgroundsPrinter.PrintBackgrounds(backgrounds);
            backgrounds.SetBackground(characterBackgroundsPrinter);

            Skills skills = new Skills(characterClass);
            SkillsPrinter skillsPrinter = new SkillsPrinter();

            skills.AddSkillsFromBackground(backgrounds.ReturnPlayersBackgroundsCollection().First().Value);

            characterClassPrinter.PrintClassChoice(characterClass);
            healthPrinter.PrintHealthOfCharacter(characterHealth);
            healthPrinter.PrintHitDieOfCharacter(characterHealth);
            characterBackgroundsPrinter.PrintChosenBackground(backgrounds);
            skillsPrinter.PrintSkills(skills.ReturnSkills());

            CharacterAttributePrinter attributePrinter = new CharacterAttributePrinter();
            attributePrinter.PrintAttributes(attributesCollection);
        }
    }
}