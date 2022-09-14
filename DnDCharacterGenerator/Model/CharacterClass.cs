using DnDCharacterGenerator.View;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.Model
{
    internal class CharacterClass
    {
        private string characterClass;
        private List<string> classSkills = new List<string>();
        private List<string> dummyClassSkills = new List<string>();

        public CharacterClass(int charactersClass, CharacterClassPrinter printer)
        {
            switch (charactersClass)
            {
                case 1:
                    characterClass = "Barbarian";
                    break;

                case 2:
                    characterClass = "Bard";
                    break;

                case 3:
                    characterClass = "Cleric";
                    break;

                case 4:
                    characterClass = "Druid";
                    break;

                case 5:
                    characterClass = "Fighter";
                    break;

                case 6:
                    characterClass = "Monk";
                    break;

                case 7:
                    characterClass = "Paladin";
                    break;

                case 8:
                    characterClass = "Ranger";
                    break;

                case 9:
                    characterClass = "Rogue";
                    break;

                case 10:
                    characterClass = "Sorcerer";
                    break;

                case 11:
                    characterClass = "Warlock";
                    break;

                case 12:
                    characterClass = "Wizard";
                    break;
            }

            SetClassSkills(printer);
        }

        private void ChooseTwoClassSkills(CharacterClassPrinter printer)
        {
            printer.SetFirstClassSkillText();
            printer.PrintSkillList(classSkills);

            var input = printer.ReadInput();
            while (!AddSkillToList(input, printer))
            {
                input = printer.ReadInput();
            }

            printer.ClearConsole();
            printer.SetSecondClassSkillText();
            printer.PrintSkillList(classSkills);

            input = printer.ReadInput();
            while (!AddSkillToList(input, printer))
            {
                input = printer.ReadInput();
            }
            classSkills = dummyClassSkills;
            printer.ClearConsole();
        }

        private void ChooseThreeClassSkills(CharacterClassPrinter printer)
        {
            printer.SetFirstClassSkillText();
            printer.PrintSkillList(classSkills);

            var input = printer.ReadInput();
            while (!AddSkillToList(input, printer))
            {
                input = printer.ReadInput();
            }

            printer.ClearConsole();
            printer.SetSecondClassSkillText();
            printer.PrintSkillList(classSkills);

            input = printer.ReadInput();
            while (!AddSkillToList(input, printer))
            {
                input = printer.ReadInput();
            }

            printer.ClearConsole();
            printer.SetThirdClassSkillText();
            printer.PrintSkillList(classSkills);

            input = printer.ReadInput();
            while (!AddSkillToList(input, printer))
            {
                input = printer.ReadInput();
            }
            classSkills = dummyClassSkills;
            printer.ClearConsole();
        }

        private void ChooseFourClassSkills(CharacterClassPrinter printer)
        {
            printer.SetFirstClassSkillText();
            printer.PrintSkillList(classSkills);

            var input = printer.ReadInput();
            while (!AddSkillToList(input, printer))
            {
                input = printer.ReadInput();
            }

            printer.ClearConsole();
            printer.SetSecondClassSkillText();
            printer.PrintSkillList(classSkills);

            input = printer.ReadInput();
            while (!AddSkillToList(input, printer))
            {
                input = printer.ReadInput();
            }

            printer.ClearConsole();
            printer.SetThirdClassSkillText();
            printer.PrintSkillList(classSkills);

            input = printer.ReadInput();
            while (!AddSkillToList(input, printer))
            {
                input = printer.ReadInput();
            }

            printer.ClearConsole();
            printer.SetFourthClassSkillText();
            printer.PrintSkillList(classSkills);
            
            input = printer.ReadInput();
            while (!AddSkillToList(input, printer))
            {
                input = printer.ReadInput();
            }

            classSkills = dummyClassSkills;
            printer.ClearConsole();
        }

        private bool AddSkillToList(string input, CharacterClassPrinter printer)
        {
            if (classSkills.Contains(input))
            {
                dummyClassSkills.Add(input);
                classSkills.Remove(input);
                return true;
            }
            else
            {
                printer.InvalidInputWarning();
                return false;
            }
        }
        private void SetClassSkills(CharacterClassPrinter printer)
        {
            switch (characterClass)
            {
                case "Barbarian":
                    classSkills.Add("Animal Handling");
                    classSkills.Add("Athletics");
                    classSkills.Add("Intimidation");
                    classSkills.Add("Nature");
                    classSkills.Add("Perception");
                    ChooseTwoClassSkills(printer);
                    break;

                case "Bard":
                    classSkills.Add("Acrobatics");
                    classSkills.Add("Animal Handling");
                    classSkills.Add("Arcana");
                    classSkills.Add("Athletics");
                    classSkills.Add("Deception");
                    classSkills.Add("History");
                    classSkills.Add("Insight");
                    classSkills.Add("Intimidation");
                    classSkills.Add("Investigation");
                    classSkills.Add("Medicine");
                    classSkills.Add("Nature");
                    classSkills.Add("Perception");
                    classSkills.Add("Performance");
                    classSkills.Add("Persuasion");
                    classSkills.Add("Religion");
                    classSkills.Add("Sleight of Hand");
                    classSkills.Add("Stealth");
                    classSkills.Add("Survival");
                    ChooseThreeClassSkills(printer);
                    break;

                case "Cleric":
                    classSkills.Add("History");
                    classSkills.Add("Insight");
                    classSkills.Add("Medicine");
                    classSkills.Add("Persuasion");
                    classSkills.Add("Religion");
                    ChooseTwoClassSkills(printer);
                    break;

                case "Druid":
                    classSkills.Add("Arcana");
                    classSkills.Add("Animal Handling");
                    classSkills.Add("Insight");
                    classSkills.Add("Medicine");
                    classSkills.Add("Nature");
                    classSkills.Add("Perception");
                    classSkills.Add("Religion");
                    classSkills.Add("Survival");
                    ChooseTwoClassSkills(printer);
                    break;

                case "Fighter":
                    classSkills.Add("Acrobatics");
                    classSkills.Add("Animal Handling");
                    classSkills.Add("Athletics");
                    classSkills.Add("History");
                    classSkills.Add("Insight");
                    classSkills.Add("Intimidation");
                    classSkills.Add("Perception");
                    classSkills.Add("Survival");
                    ChooseTwoClassSkills(printer);
                    break;

                case "Monk":
                    classSkills.Add("Acrobatics");
                    classSkills.Add("Athletics");
                    classSkills.Add("History");
                    classSkills.Add("Insight");
                    classSkills.Add("Religion");
                    classSkills.Add("Stealth");
                    ChooseTwoClassSkills(printer);
                    break;

                case "Paladin":
                    classSkills.Add("Athletics");
                    classSkills.Add("Insight");
                    classSkills.Add("Intimidation");
                    classSkills.Add("Medicine");
                    classSkills.Add("Persuasion");
                    classSkills.Add("Religion");
                    ChooseTwoClassSkills(printer);
                    break;

                case "Ranger":
                    classSkills.Add("Animal Handling");
                    classSkills.Add("Athletics");
                    classSkills.Add("Insight");
                    classSkills.Add("Investigation");
                    classSkills.Add("Nature");
                    classSkills.Add("Perception");
                    classSkills.Add("Stealth");
                    classSkills.Add("Survival");
                    ChooseTwoClassSkills(printer);
                    break;

                case "Rogue":
                    classSkills.Add("Acrobatics");
                    classSkills.Add("Athletics");
                    classSkills.Add("Deception");
                    classSkills.Add("Insight");
                    classSkills.Add("Intimidation");
                    classSkills.Add("Investigation");
                    classSkills.Add("Perception");
                    classSkills.Add("Performance");
                    classSkills.Add("Persuasion");
                    classSkills.Add("Sleight of Hand");
                    classSkills.Add("Stealth");
                    ChooseFourClassSkills(printer);
                    break;

                case "Sorcerer":
                    classSkills.Add("Arcana");
                    classSkills.Add("Deception");
                    classSkills.Add("Insight");
                    classSkills.Add("Intimidation");
                    classSkills.Add("Persuasion");
                    classSkills.Add("Religion");
                    ChooseTwoClassSkills(printer);
                    break;

                case "Warlock":
                    classSkills.Add("Arcana");
                    classSkills.Add("Deception");
                    classSkills.Add("History");
                    classSkills.Add("Intimidation");
                    classSkills.Add("Investigation");
                    classSkills.Add("Nature");
                    classSkills.Add("Religion");
                    ChooseTwoClassSkills(printer);
                    break;

                case "Wizard":
                    classSkills.Add("Arcana");
                    classSkills.Add("History");
                    classSkills.Add("Insight");
                    classSkills.Add("Investigation");
                    classSkills.Add("Medicine");
                    classSkills.Add("Religion");
                    ChooseTwoClassSkills(printer);
                    break;
            }


            foreach (string skill in classSkills)
            {
                Console.WriteLine(skill);
            }
            Console.ReadLine();

        }

        public string ReturnCharacterClass()
        {
            return characterClass;
        }

        public List<string> ReturnClassSkills()
        {
            return classSkills;
        }
    }
}
