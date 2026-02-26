using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Facade
{
    public class InvoiceService
    {
        public void GenerateInvoice(string productId)
        {
            Console.WriteLine("Generating invoice...");
        }
    }
}
