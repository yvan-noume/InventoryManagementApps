using InventoryManagementApplicationLayer.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplicationLayer.API
{
    public interface ICategoryServices
    {
        public bool CreateCategory(CategoryDTO category);

        public bool DeleteCategory(CategoryDTO category);

        public bool UpdateCategory(CategoryDTO category);

        public List<CategoryDTO> GetAllCategories();

        public List<ProductDTO> GetAllProducts(CategoryDTO category);
    }
}
