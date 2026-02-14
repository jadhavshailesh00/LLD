namespace LLD.behavioral_design_patterns.Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy strategy;

        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            strategy = paymentStrategy;
        }

        public void MakePayment(double amount)
        {
            strategy.Pay(amount);
        }
    }
}
