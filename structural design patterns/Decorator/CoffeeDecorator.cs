using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Decorator
{
    public abstract class CoffeeDecorator : ICoffee
    {
        protected readonly ICoffee _coffee;

        protected CoffeeDecorator(ICoffee coffee)
        {
            _coffee = coffee;
        }

        public virtual string GetDescription() => _coffee.GetDescription();
        public virtual double GetCost() => _coffee.GetCost();
    }
}
