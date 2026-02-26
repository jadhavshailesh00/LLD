using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Adapter
{
    public class PaymentAdapter : IPaymentProcessor
    {
        private readonly ThirdPartyPaymentGateway _gateway;

        public PaymentAdapter(ThirdPartyPaymentGateway gateway)
        {
            _gateway = gateway;
        }

        public void ProcessPayment(decimal amount)
        {
            double convertedAmount = (double)amount;
            _gateway.MakeTransaction(convertedAmount);
        }
    }
}
