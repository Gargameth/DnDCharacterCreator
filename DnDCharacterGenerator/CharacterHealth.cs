using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator
{
    internal class CharacterHealth
    {
        private Dictionary<int, int> hitDie = new Dictionary<int, int>();
        private int health = 0;

        public CharacterHealth(string characterClass, int constitutionModifier)
        {
            switch (characterClass)
            {
                case "Barbarian":
                    hitDie.Add(12, 1);
                    break;

                case "Bard":
                    hitDie.Add(8, 1);
                    break;

                case "Cleric":
                    hitDie.Add(8, 1);
                    break;

                case "Druid":
                    hitDie.Add(8, 1);
                    break;

                case "Fighter":
                    hitDie.Add(10, 1);
                    break;

                case "Monk":
                    hitDie.Add(8, 1);
                    break;

                case "Paladin":
                    hitDie.Add(10, 1);
                    break;

                case "Ranger":
                    hitDie.Add(10, 1);
                    break;

                case "Rogue":
                    hitDie.Add(8, 1);
                    break;

                case "Sorcerer":
                    hitDie.Add(6, 1);
                    break;

                case "Warlock":
                    hitDie.Add(8, 1);
                    break;

                case "Wizard":
                    hitDie.Add(6, 1);
                    break;
            }
            
            if (hitDie.First().Value == 1)
            {
                this.health = hitDie.First().Key + constitutionModifier;
            }

            else
            {
                Random random = new Random();
                for (int i = 0; i < hitDie.First().Value; i++)
                {
                    this.health += random.Next(0, hitDie.First().Value) + constitutionModifier;
                }
            }
        }

        public int ReturnHealth()
        {
            return this.health;
        }

        public Dictionary<int, int> ReturnHitDie()
        {
            return this.hitDie;
        }
    }
}
