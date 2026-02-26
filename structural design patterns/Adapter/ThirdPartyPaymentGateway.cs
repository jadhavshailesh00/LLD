using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Adapter
{
    public class ThirdPartyPaymentGateway
    {
        public void MakeTransaction(double total)
        {
            Console.WriteLine($"Processing payment of {total} via Third Party Gateway");
        }
    }
}
