namespace LLD.structural_design_patterns.Facade
{
    internal class Facade
    {
        public static void Run()
        {
            var orderFacade = new OrderFacade();
            orderFacade.PlaceOrder("P1001", 500);
        }
    }
}
