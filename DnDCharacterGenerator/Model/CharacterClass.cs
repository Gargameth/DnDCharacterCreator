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
            while (dummyClassSkills.Count == 0)
            {
                AddSkillToList(input, printer);
            }

            printer.ClearConsole();
            printer.SetSecondClassSkillText();
            printer.PrintSkillList(classSkills);

            input = printer.ReadInput();
            while (dummyClassSkills.Count == 1)
            {
                AddSkillToList(input, printer);
            }
            classSkills = dummyClassSkills;
            printer.ClearConsole();
        }

        private void ChooseThreeClassSkills(CharacterClassPrinter printer)
        {
            printer.SetFirstClassSkillText();
            printer.PrintSkillList(classSkills);

            var input = printer.ReadInput();
            while (dummyClassSkills.Count == 0)
            {
                AddSkillToList(input, printer);
            }

            printer.ClearConsole();
            printer.SetSecondClassSkillText();
            printer.PrintSkillList(classSkills);

            input = printer.ReadInput();
            while (dummyClassSkills.Count == 1)
            {
                AddSkillToList(input, printer);
            }

            printer.ClearConsole();
            printer.SetThirdClassSkillText();
            printer.PrintSkillList(classSkills);

            input = printer.ReadInput();
            while (dummyClassSkills.Count == 1)
            {
                AddSkillToList(input, printer);
            }
            classSkills = dummyClassSkills;
        }

        private void AddSkillToList(string input, CharacterClassPrinter printer)
        {
            if (classSkills.Contains(input))
            {
                dummyClassSkills.Add(input);
                classSkills.Remove(input);
            }
            else
            {
                printer.InvalidInputWarning();
                input = printer.ReadInput();
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
                    break;

                case "Druid":
                    break;

                case "Fighter":
                    break;

                case "Monk":
                    break;

                case "Paladin":
                    break;

                case "Ranger":
                    break;

                case "Rogue":
                    break;

                case "Sorcerer":
                    break;

                case "Warlock":
                    break;

                case "Wizard":
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
