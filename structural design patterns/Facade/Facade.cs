using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Facade
{
    internal class Facade
    {
        public static void  Run()
        {
            var orderFacade = new OrderFacade();
            orderFacade.PlaceOrder("P1001", 500);
        }
    }
}
