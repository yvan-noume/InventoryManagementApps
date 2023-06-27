using InventoryManagementDomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplicationLayer.Data_Transfer_Objects
{
    public class CategoryDTO
    {
        public string Name { get; set; }
        public List<ProductDTO> Products { get; set; }
        public string Description { get; set; }
    }
}
