namespace LLD.structural_design_patterns.Adapter
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
