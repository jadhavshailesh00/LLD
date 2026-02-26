using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LLD.structural_design_patterns.Facade
{
    public class OrderFacade
    {
        private readonly InventoryService _inventory;
        private readonly PaymentService _payment;
        private readonly InvoiceService _invoice;
        private readonly ShippingService _shipping;

        public OrderFacade()
        {
            _inventory = new InventoryService();
            _payment = new PaymentService();
            _invoice = new InvoiceService();
            _shipping = new ShippingService();
        }

        public void PlaceOrder(string productId, decimal amount)
        {
            if (!_inventory.CheckStock(productId))
            {
                Console.WriteLine("Product out of stock.");
                return;
            }

            _payment.ProcessPayment(amount);
            _invoice.GenerateInvoice(productId);
            _shipping.ShipProduct(productId);

            Console.WriteLine("Order completed successfully.");
        }
    }
}
