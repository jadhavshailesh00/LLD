namespace LLD.behavioral_design_patterns.State
{
    public class AuthenticatedState : IATMState
    {
        public void InsertCard(ATM atm)
        {
            Console.WriteLine("Transaction in progress.");
        }

        public void EnterPin(ATM atm)
        {
            Console.WriteLine("Already authenticated.");
        }

        public void WithdrawMoney(ATM atm)
        {
            Console.WriteLine("Dispensing cash...");
            atm.SetState(new NoCardState());
        }
    }

}
