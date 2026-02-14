using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.ChainofResponsibility
{
    public class Director : ExpenseHandler
    {
        public override void HandleRequest(decimal amount)
        {
            if (amount <= 5000)
            {
                Console.WriteLine("Director approved the request.");
            }
            else if (_nextHandler != null)
            {
                _nextHandler.HandleRequest(amount);
            }
        }
    }
}
