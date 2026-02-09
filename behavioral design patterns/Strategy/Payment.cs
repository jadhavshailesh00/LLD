using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Strategy
{
    public class Payment
    {

        public void Run()
        {
            PaymentContext payContext = new PaymentContext();

            payContext.SetPaymentStrategy(new CardPaymentStrategy());
            payContext.MakePayment(1000);


            payContext.SetPaymentStrategy(new UpiPaymentStrategy());
            payContext.MakePayment(500);
        }

    }
}
