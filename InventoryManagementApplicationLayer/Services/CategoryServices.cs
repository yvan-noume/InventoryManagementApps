using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InventoryManagementApplicationLayer.Services
{
    public class CategoryServices
    {
        private readonly ICategoryServices _categoryServices;

        public CategoryServices(ICategoryServices categoryServices)
        {
            _categoryServices = categoryServices;
        }

        public bool CreateCategory(string name, string description)
        {
            var categoryDTO = new CategoryDTO { Name = name, Products = null, Description= description};
            return _categoryServices.CreateCategory(categoryDTO);
        }

        public bool DeleteCategory(string name, string description)
        {
            var categoryDTO = new CategoryDTO { Name = name, Products = null, Description = description };
            return _categoryServices.DeleteCategory(categoryDTO);
        }

        public bool UpdateCategory(string name, string description)
        {
            var categoryDTO = new CategoryDTO { Name = name, Products = null, Description = description };
            return _categoryServices.UpdateCategory(categoryDTO);
        }

        public List<CategoryDTO> GetAllCategories()
        {
            return _categoryServices.GetAllCategories();
        }

        public List<ProductDTO> GetAllProducts(CategoryDTO category)
        {
            return _categoryServices.GetAllProducts(category);
        }
    }
}
