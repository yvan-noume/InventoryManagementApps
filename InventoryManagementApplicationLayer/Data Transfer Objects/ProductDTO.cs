using InventoryManagementDomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplicationLayer.Data_Transfer_Objects
{
    public class ProductDTO
    {
        public string Name { get; set; }
        public CategoryDTO Category { get; set; }
        public DateTime ExpiringDate { get; set; }
        public int Stock { get; set; }
        public string Description { get; set; }
    }
}
