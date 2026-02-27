namespace LLD.behavioral_design_patterns.Observer
{
    public class EmailNotifier : IObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine($"Email: Stock price updated to {price}");
        }
    }

}
