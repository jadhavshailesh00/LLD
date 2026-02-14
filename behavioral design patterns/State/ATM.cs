namespace LLD.behavioral_design_patterns.State
{
    public class ATM
    {
        private IATMState _currentState;

        public ATM()
        {
            _currentState = new NoCardState();
        }

        public void SetState(IATMState state)
        {
            _currentState = state;
        }

        public void InsertCard() => _currentState.InsertCard(this);
        public void EnterPin() => _currentState.EnterPin(this);
        public void WithdrawMoney() => _currentState.WithdrawMoney(this);
    }

}
