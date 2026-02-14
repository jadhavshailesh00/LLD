namespace LLD.behavioral_design_patterns.Strategy
{
    public class UpiPaymentStrategy : IPaymentStrategy
    {
        public void Pay(double amount)
        {
            Console.WriteLine($"Paid {amount} using UPI Payment");
        }
    }
}
