using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Strategy
{
    public interface IPaymentStrategy
    {
        public void Pay(double amount);
    }
}
