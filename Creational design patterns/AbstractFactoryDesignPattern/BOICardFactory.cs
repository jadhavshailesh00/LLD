namespace LLD.CreationalDesignPattern.AbstractFactoryDesignPattern
{
    internal class BOICardFactory : ICardFactory
    {
        public ICard CreateCCCard()
        {
            return new BOICC();
        }

        public ICard CreateATMCard()
        {
            return new BOIATM();
        }
    }
}
