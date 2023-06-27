using InventoryManagementApplicationLayer;
using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace InventoryManagementPresentationLayer.ViewModels
{
    public class CustomersViewModel: INotifyPropertyChanged
    {
        private string _firstName;
        private string _lastName;
        private string _email;
        private int _phoneNumber;
        private string _address;

        public List<CustomerDTO> Customers { get; set; }
        public ICustomerServices CustomerServices { get; set; }

        public CustomersViewModel(ICustomerServices customerService) 
        {
            CustomerServices = customerService;
            Customers = CustomerServices.GetAllCustomers();
        }
        public string FirstName 
        {
            get { return  _firstName; }
            set
            {
                if (_firstName != value)
                {
                    _firstName = value;
                    OnPropertyChanged(nameof(FirstName));
                }
            }
        }
        public string LastName
        {
            get { return _lastName; }
            set
            {
                if (_lastName != value)
                {
                    _lastName = value;
                    OnPropertyChanged(nameof(LastName));
                }
            }
        }
        public string Email
        {
            get { return _email; }
            set
            {
                if (_email != value)
                {
                    _email = value;
                    OnPropertyChanged(nameof(Email));
                }
            }
        }
        public int PhoneNumber
        {
            get { return _phoneNumber; }
            set
            {
                if (_phoneNumber != value)
                {
                    _phoneNumber = value;
                    OnPropertyChanged(nameof(PhoneNumber));
                }
            }
        }
        public string Address
        {
            get { return _address; }
            set
            {
                if (_address != value)
                {
                    _address = value;
                    OnPropertyChanged(nameof(Address));
                }
            }
        }

        public event PropertyChangedEventHandler? PropertyChanged;

        public void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public void CreateCustomer()
        {
            var customer = new CustomerDTO { FirstName = FirstName,LastName=LastName,Email=Email, PhoneNumber=PhoneNumber,Address= Address,DateMembership=DateTime.Now };
            CustomerServices.CreateCustomer(customer);
        }

        public async void LoadCustomers()
        {
            Customers = await CustomerServices.GetAllCustomersAsync();
        }
    }
}
