using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDataAccessLayer
{
    public class ProductDataOperations : IProductServices
    {
        public List<ProductDTO> GetAllProducts()
        {
            throw new NotImplementedException();
        }

        public List<ProductDTO> GetProducts(CategoryDTO category)
        {
            throw new NotImplementedException();
        }
    }
}
