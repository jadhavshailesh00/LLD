using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDSARepository.DesignPattern.CreationalDesignPattern.BuilderDesignPattern
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
