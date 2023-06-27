using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplicationLayer.API
{
    public interface ICustomerServices
    {
        public bool CreateCustomer(CustomerDTO customer);

        public bool DeleteCustomer(CustomerDTO customer);

        public bool UpdateCustomer(CustomerDTO customer);

        public List<CustomerDTO> GetAllCustomers();

        public Task<List<CustomerDTO>> GetAllCustomersAsync();
    }
}
