using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Facade
{
    public class PaymentService
    {
        public void ProcessPayment(decimal amount)
        {
            Console.WriteLine("Processing payment...");
        }
    }
}
