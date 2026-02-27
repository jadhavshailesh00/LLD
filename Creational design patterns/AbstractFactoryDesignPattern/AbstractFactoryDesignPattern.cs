namespace LLD.CreationalDesignPattern.AbstractFactoryDesignPattern
{
    public static class AbstractFactoryDesignPattern
    {
        public static ICardFactory CreateFactory(string name)
        {
            if (name == "SBI")
            {
                return new SBICardFactory();
            }
            else if (name == "BOI")
            {
                return new BOICardFactory();
            }
            else
            {
                return new BOICardFactory(); //default 
            }
        }
    }
}
