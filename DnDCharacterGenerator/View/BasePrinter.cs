using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DnDCharacterGenerator.View
{
    internal abstract class BasePrinter
    {
        public string? ReadInput()
        {
            var input = Console.ReadLine();
            return input;
        }

        public void InvalidInputWarning()
        {
            Console.WriteLine("Invalid input. Please try again.");
        }

        public void ClearConsole()
        {
            Console.Clear();
        }
    }
}
