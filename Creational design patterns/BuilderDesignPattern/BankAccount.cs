using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDSARepository.DesignPattern.CreationalDesignPattern.BuilderDesignPattern
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
