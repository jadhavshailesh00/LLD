namespace LLD.CreationalDesignPattern.BuilderDesignPattern
{
    internal class BankAccount
    {
        public string Name { get; set; }
        public string AccountType { get; set; }
        public bool DebitCard { get; set; }
        public bool OnlineBanking { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}, Type: {AccountType}, DebitCard: {DebitCard}, OnlineBanking: {OnlineBanking}";
        }
    }
}
