using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Adapter
{
    public class Adapter
    {

        public  static void Run()
        {
            ThirdPartyPaymentGateway thirdPartyGateway = new ThirdPartyPaymentGateway();

            IPaymentProcessor paymentProcessor =
                new PaymentAdapter(thirdPartyGateway);

            paymentProcessor.ProcessPayment(250.75m);
        }
    }
}
