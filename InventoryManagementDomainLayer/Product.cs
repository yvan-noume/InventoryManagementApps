using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDomainLayer
{
    public class Product
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Category Category { get; set; }
        public DateTime ExpiringDate { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    }
}
