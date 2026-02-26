using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Facade
{
    public class InventoryService
    {
        public bool CheckStock(string productId)
        {
            Console.WriteLine("Checking inventory...");
            return true;
        }
    }
}
