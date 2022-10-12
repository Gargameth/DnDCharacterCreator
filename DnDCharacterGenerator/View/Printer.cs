using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DnDCharacterGenerator.Model;

namespace DnDCharacterGenerator.View
{
    internal class Printer
    {
        public Printer()
        {
        }

        public void PrintGreetings()
        {
            Console.WriteLine("Welcome to a rudimentary D&D character creator.\n");
            Console.WriteLine("It looks janky, I know, but nobody is perfect. Especially me.\n");
            Console.WriteLine("It will get better, trust me. We have the technology. The skills are not here yet, but are on their way.");
        }
    }
}
