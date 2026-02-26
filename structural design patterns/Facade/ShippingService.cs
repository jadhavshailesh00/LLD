using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Facade
{
    public class ShippingService
    {
        public void ShipProduct(string productId)
        {
            Console.WriteLine("Arranging shipping...");
        }
    }
}
