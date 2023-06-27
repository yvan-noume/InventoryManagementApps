using InventoryManagementApplicationLayer.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplicationLayer.API
{
    public interface IOrderServices
    {
        public bool GetOrders(CustomerDTO customer);

        public List<OrderDTO> GetAllOrders();
    }
}
