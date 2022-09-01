using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    internal class CharacterClass
    {
        private string characterClass;
        private List<string> classSkills = new List<string>();

        public CharacterClass(int charactersClass)
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
            
            SetClassSkills();
        }

        private void SetClassSkills()
        {
            Console.WriteLine("Set your first class skill (try not make typos; letters are case sensitive): \n");
            List<string> dummyClassSkills = new List<string>();
            switch (characterClass)
            {
                case "Barbarian":
                    classSkills.Add("Animal Handling");
                    classSkills.Add("Athletics");
                    classSkills.Add("Intimidation");
                    classSkills.Add("Nature");
                    classSkills.Add("Perception");
                    
                    foreach(string skill in classSkills)
                    {
                        Console.WriteLine(skill);
                    }

                    var firstInput = Console.ReadLine();
                    while (dummyClassSkills.Count == 0)
                    {
                        if (classSkills.Contains(firstInput))
                        {
                            dummyClassSkills.Add(firstInput);
                            classSkills.Remove(firstInput);
                        }
                        else
                        {
                            Console.WriteLine("I told you to watch them typos... ya donkey! Try again.");
                            firstInput = Console.ReadLine();
                        }
                    }
                    
                    Console.Clear();
                    Console.WriteLine("Now choose your second class skill (with the above mentiones typing rules): \n");
                    foreach (string skill in classSkills)
                    {
                        Console.WriteLine(skill);
                    }
                    var secondInput = Console.ReadLine();
                    while (dummyClassSkills.Count == 1)
                    {
                        if (classSkills.Contains(secondInput))
                        {
                            dummyClassSkills.Add(secondInput);
                        }
                        else
                        {
                            Console.WriteLine("I told you to watch them typos... ya donkey! Try again.");
                            secondInput = Console.ReadLine();
                        }
                    }
                    foreach (string skill in classSkills)
                    {
                        Console.WriteLine(skill);
                    }

                    Console.Clear();

                    break;

                case "Bard":
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

            classSkills = dummyClassSkills;
            foreach(string skill in classSkills)
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
