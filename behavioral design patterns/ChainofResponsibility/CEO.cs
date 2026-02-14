using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.ChainofResponsibility
{
    public class CEO : ExpenseHandler
    {
        public override void HandleRequest(decimal amount)
        {
            if (amount <= 20000)
            {
                Console.WriteLine("CEO approved the request.");
            }
            else
            {
                Console.WriteLine("Request requires board approval.");
            }
        }
    }
}
