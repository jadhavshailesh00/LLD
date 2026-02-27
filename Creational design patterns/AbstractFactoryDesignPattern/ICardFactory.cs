namespace MyDSARepository.DesignPattern.CreationalDesignPattern.AbstractFactoryDesignPattern
{
    public interface ICardFactory
    {
        public ICard CreateCCCard();
        public ICard CreateATMCard();
    }
}
