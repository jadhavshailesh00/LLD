using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Decorator
{
    public class Decorator
    {

        public void run()
        {

            ICoffee coffee = new SimpleCoffee();
            coffee = new MilkDecorator(coffee);
            coffee = new SugarDecorator(coffee);

            Console.WriteLine(coffee.GetDescription());
            Console.WriteLine(coffee.GetCost());

        }
    }
}
