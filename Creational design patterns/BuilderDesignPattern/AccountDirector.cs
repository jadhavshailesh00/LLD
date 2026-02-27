using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyDSARepository.DesignPattern.CreationalDesignPattern.BuilderDesignPattern
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
