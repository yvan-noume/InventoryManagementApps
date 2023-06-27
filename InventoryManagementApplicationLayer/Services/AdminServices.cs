using InventoryManagementDomainLayer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InventoryManagementApplicationLayer.Services
{
    public class AdminServices
    {
        private Admin _admin;

        //public AdminServices(string name, string email, string password) 
        //{ 
        //    _admin = new Admin(name, email, password);
        //}
        public bool CreateAdminService()
        {
            return _admin.CreateAdmin();
        }

        public bool DeleteAdminService()
        {
            return _admin.DeleteAdmin();
        }

        public bool UpdateAdminService()
        {
            return _admin.UpdateAdmin();
        }

        public bool GetAdminService()
        {
            return _admin.GetAdmin();
        }
    }
}
