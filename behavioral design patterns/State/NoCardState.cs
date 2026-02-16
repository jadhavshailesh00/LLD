namespace LLD.behavioral_design_patterns.State
{
    public class NoCardState : IATMState
    {
        public void InsertCard(ATM atm)
        {
            Console.WriteLine("Card Inserted");
            atm.SetState(new HasCardState());
        }

        public void EnterPin(ATM atm)
        {
            Console.WriteLine("Insert card first.");
        }

        public void WithdrawMoney(ATM atm)
        {
            Console.WriteLine("Insert card first.");
        }
    }

}
