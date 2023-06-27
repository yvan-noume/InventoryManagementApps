using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDomainLayer
{
    public class Order
    {
        public Customer Customer { get; set; }
        public Dictionary<Product, int> Products { get; set; }
        public DateTime Date { get; set; }
    }
}
