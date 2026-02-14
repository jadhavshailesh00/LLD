namespace LLD.behavioral_design_patterns.State
{
    public class HasCardState : IATMState
    {
        public void InsertCard(ATM atm)
        {
            Console.WriteLine("Card already inserted.");
        }

        public void EnterPin(ATM atm)
        {
            Console.WriteLine("PIN verified.");
            atm.SetState(new AuthenticatedState());
        }

        public void WithdrawMoney(ATM atm)
        {
            Console.WriteLine("Enter PIN first.");
        }
    }

}
