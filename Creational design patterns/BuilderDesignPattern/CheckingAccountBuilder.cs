namespace LLD.CreationalDesignPattern.BuilderDesignPattern
{
    internal class CheckingAccountBuilder : IAccountBuilder
    {
        private BankAccount account = new BankAccount();

        public void SetName() => account.Name = "John Doe";
        public void SetAccountType() => account.AccountType = "Checking";
        public void AddDebitCard() => account.DebitCard = true;
        public void AddOnlineBanking() => account.OnlineBanking = true;
        public BankAccount GetAccount() => account;
    }

}
