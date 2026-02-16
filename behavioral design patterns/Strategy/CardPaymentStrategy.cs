namespace LLD.behavioral_design_patterns.Strategy
{
    public class CardPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using Card Payment");
        }
    }
}
