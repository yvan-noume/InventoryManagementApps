using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using InventoryManagementApplicationLayer.API;

namespace InventoryManagementApplicationLayer.Services
{
    public class CustomerServices
    {
        private readonly ICustomerServices _customerServices;

        public CustomerServices(ICustomerServices customerServices)
        {
            _customerServices = customerServices;
        }

        public bool CreateCustomer(string firstName, string lastName, string email, int phoneNumber, string address, DateTime dateMembership)
        {
            var customerDTO = new CustomerDTO { FirstName=firstName,LastName=lastName,Email=email,PhoneNumber=phoneNumber,Address=address,DateMembership=dateMembership };
            return _customerServices.CreateCustomer(customerDTO);
        }

        public bool DeleteCustomer(string firstName, string lastName, string email, int phoneNumber, string address)
        {
            var customerDTO = new CustomerDTO { FirstName = firstName, LastName = lastName, Email = email, PhoneNumber = phoneNumber, Address = address, DateMembership = null};
            return _customerServices.DeleteCustomer(customerDTO);
        }

        public bool UpdateCustomer(string firstName, string lastName, string email, int phoneNumber, string address)
        {
            var customerDTO = new CustomerDTO { FirstName = firstName, LastName = lastName, Email = email, PhoneNumber = phoneNumber, Address = address, DateMembership = null };
            return _customerServices.UpdateCustomer(customerDTO);
        }
        public List<CustomerDTO> GetAllCustomers()
        {
            return _customerServices.GetAllCustomers();
        }

        public Task<List<CustomerDTO>> GetAllCustomersAsync()
        {
            return _customerServices.GetAllCustomersAsync();
        }
    }
}
