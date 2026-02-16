namespace LLD.behavioral_design_patterns.State
{
    public interface IATMState
    {
        public void InsertCard(ATM atm);
        public void EnterPin(ATM atm);
        public void WithdrawMoney(ATM atm);
    }
}
