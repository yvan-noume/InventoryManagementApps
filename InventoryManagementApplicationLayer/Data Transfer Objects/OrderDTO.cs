using InventoryManagementDomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplicationLayer.Data_Transfer_Objects
{
    public class OrderDTO
    {
        public CustomerDTO Customer { get; set; }
        public Dictionary<ProductDTO, int> Products { get; set; }
        public DateTime Date { get; set; }
    }
}
