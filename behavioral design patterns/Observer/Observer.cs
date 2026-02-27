namespace LLD.behavioral_design_patterns.Observer
{
    public class Observer
    {
        public static void Run()
        {
            var stock = new Stock();

            var emailObserver = new EmailNotifier();
            var smsObserver = new SmsNotifier();

            stock.Attach(emailObserver);
            stock.Attach(smsObserver);

            stock.Price = 100;
            stock.Price = 120;

            stock.Detach(emailObserver);
            stock.Price = 150;
        }
    }
}
