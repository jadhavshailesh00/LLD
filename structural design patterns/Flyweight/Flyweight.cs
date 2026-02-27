using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Flyweight
{
    internal class Flyweight
    {

        public static void Run()
        {
            var factory = new CharacterFactory();

            var charA1 = factory.GetCharacter('A', "Arial", 12, "Black");
            var charA2 = factory.GetCharacter('A', "Arial", 12, "Black");

            charA1.Display(1);
            charA2.Display(2);
        }
    }
}
