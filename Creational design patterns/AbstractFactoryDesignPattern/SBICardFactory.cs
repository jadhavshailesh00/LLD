namespace LLD.CreationalDesignPattern.AbstractFactoryDesignPattern
{
    internal class SBICardFactory : ICardFactory
    {
        public ICard CreateCCCard()
        {
            return new SBICC();
        }

        public ICard CreateATMCard()
        {
            return new SBIATM();
        }
    }
}
