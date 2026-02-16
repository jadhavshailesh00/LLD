namespace LLD.behavioral_design_patterns.Decorator
{
    public class SugarDecorator : CoffeeDecorator
    {
        public SugarDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() =>
            base.GetDescription() + ", Sugar";

        public override double GetCost() =>
            base.GetCost() + 5;
    }
}
