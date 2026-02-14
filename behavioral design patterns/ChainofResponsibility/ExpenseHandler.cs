using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.ChainofResponsibility
{
    public abstract class ExpenseHandler
    {
        protected ExpenseHandler _nextHandler;

        public void SetNext(ExpenseHandler nextHandler)
        {
            _nextHandler = nextHandler;
        }

        public abstract void HandleRequest(decimal amount);
    }

}
