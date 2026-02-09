using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Strategy
{
    public class PaymentContext
    {
        private IPaymentStrategy strategy;
      
        public void SetPaymentStrategy(IPaymentStrategy paymentStrategy)
        {
            strategy= paymentStrategy;
        }

        public void MakePayment(double amount)
        {
            strategy.Pay(amount);
        }
    }
}
