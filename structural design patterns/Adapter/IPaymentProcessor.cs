using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Adapter
{
    public interface IPaymentProcessor
    {
        void ProcessPayment(decimal amount);
    }
}
