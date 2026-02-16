namespace LLD.behavioral_design_patterns.ChainofResponsibility
{
    public class Manager : ExpenseHandler
    {
        public override void HandleRequest(decimal amount)
        {
            if (amount <= 1000)
            {
                Console.WriteLine("Manager approved the request.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(amount);
            }
        }
    }
}
