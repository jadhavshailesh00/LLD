namespace LLD.behavioral_design_patterns.Decorator
{
    public class MilkDecorator : CoffeeDecorator
    {
        public MilkDecorator(ICoffee coffee) : base(coffee) { }

        public override string GetDescription() =>
            base.GetDescription() + ", Milk";

        public override double GetCost() =>
            base.GetCost() + 10;
    }
}
