namespace LLD.behavioral_design_patterns.ChainofResponsibility
{
    public abstract class ExpenseHandler
    {
        protected ExpenseHandler _nextHandler;

        public void SetNext(ExpenseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(decimal amount);
    }

}
