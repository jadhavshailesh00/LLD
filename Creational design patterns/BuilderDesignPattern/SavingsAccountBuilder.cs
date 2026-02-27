using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDSARepository.DesignPattern.CreationalDesignPattern.BuilderDesignPattern
{
    internal class SavingsAccountBuilder : IAccountBuilder
    {
        private BankAccount account = new BankAccount();

        public void SetName() => account.Name = "Emily Watson";
        public void SetAccountType() => account.AccountType = "Savings";
        public void AddDebitCard() => account.DebitCard = false;
        public void AddOnlineBanking() => account.OnlineBanking = true;
        public BankAccount GetAccount() => account;
    }

}
