using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Services;
using InventoryManagementPresentationLayer.ViewModels;

namespace InventoryManagementPresentationLayer.Views
{
    public partial class CustomersForm : BaseForm
    {
        private CustomersViewModel customersViewModel;
        private BindingSource customerBindingSource;
        private ICustomerServices customerServices;

        public CustomersForm(ICustomerServices customerServices)
        {
            InitializeComponent();
            this.customerServices = customerServices;
            customersViewModel = new CustomersViewModel(customerServices);

            customerBindingSource = new BindingSource();
            customerBindingSource.DataSource = customersViewModel.Customers;

            customersDataGridView.DataSource = customerBindingSource;

            txtFirstName.DataBindings.Add("Text", customersViewModel, "FirstName", false);
            txtLastName.DataBindings.Add("Text", customersViewModel, "LastName", false);
            txtEmail.DataBindings.Add("Text", customersViewModel, "Email", false);
            txtPhoneNumber.DataBindings.Add("Text", customersViewModel, "PhoneNumber", false);
            txtAddress.DataBindings.Add("Text", customersViewModel, "Address", false);
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            customersViewModel.CreateCustomer();
            var viemModel = new CustomersViewModel(customerServices);
            customerBindingSource.DataSource = viemModel.Customers;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = Application.OpenForms["HomeForm"] as HomeForm;
            homeForm.Show();
        }
    }
}
