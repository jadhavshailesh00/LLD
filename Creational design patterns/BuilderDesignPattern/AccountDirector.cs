namespace LLD.CreationalDesignPattern.BuilderDesignPattern
{
    internal class AccountDirector
    {
        private IAccountBuilder builder;

        public AccountDirector(IAccountBuilder builder)
        {
            this.builder = builder;
        }

        public void OpenAccount()
        {
            builder.SetName();
            builder.SetAccountType();
            builder.AddDebitCard();
            builder.AddOnlineBanking();
        }
    }

}
