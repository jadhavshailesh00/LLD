using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.behavioral_design_patterns.Observer
{
    public class SmsNotifier : IObserver
    {
        public void Update(decimal price)
        {
            Console.WriteLine($"SMS: Stock price updated to {price}");
        }
    }
}
