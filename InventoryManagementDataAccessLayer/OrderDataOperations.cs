using InventoryManagementApplicationLayer;
using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Data_Transfer_Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementDataAccessLayer
{
    public class OrderDataOperations : IOrderServices
    {
        public List<OrderDTO> GetAllOrders()
        {
            throw new NotImplementedException();
        }

        public bool GetOrders(CustomerDTO customer)
        {
            throw new NotImplementedException();
        }
    }
}
