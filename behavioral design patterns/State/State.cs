namespace LLD.behavioral_design_patterns.State
{
    public class State
    {

        public static void Run()
        {
            ATM atm = new ATM();

            atm.InsertCard();      // NoCardState → HasCardState
            atm.EnterPin();        // HasCardState → AuthenticatedState
            atm.WithdrawMoney();   // AuthenticatedState → NoCardState

            atm.WithdrawMoney();
        }
    }
}
