namespace LLD.CreationalDesignPattern.BuilderDesignPattern
{
    internal interface IAccountBuilder
    {
        void SetName();
        void SetAccountType();
        void AddDebitCard();
        void AddOnlineBanking();
        BankAccount GetAccount();
    }
}
