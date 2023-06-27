using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Services;
using InventoryManagementPresentationLayer.ViewModels;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementPresentationLayer.Views
{
    public partial class HomeForm : BaseForm
    {
        private ICustomerServices customerServices;

        public HomeForm(ICustomerServices customerService)
        {
            InitializeComponent();
            this.customerServices = customerService;
        }

        private void btnCustomers_Click(object sender, EventArgs e)
        {
            this.Hide();
            CustomersForm customersForm;
            if (ContainsKey("CustomersForm"))
            {
                customersForm = Application.OpenForms["CustomersForm"] as CustomersForm;
                customersForm.Show();
            }
            else
            {
                customersForm = new CustomersForm(customerServices);
            }                   
            customersForm.Show();
        }

        private void btnCategories_Click(object sender, EventArgs e)
        {
            this.Hide();
            CategoriesForm categoryForm;
            if (ContainsKey("CategoriesForm"))
            {
                categoryForm = Application.OpenForms["CategoriesForm"] as CategoriesForm;
                categoryForm.Show();
            }
            else
            {
                categoryForm = new CategoriesForm();
            }
            categoryForm.Show();
        }

        private void btnNewOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            NewOrderForm newOrderForm;
            if (ContainsKey("NewOrderForm"))
            {
                newOrderForm = Application.OpenForms["NewOrderForm"] as NewOrderForm;
                newOrderForm.Show();
            }
            else
            {
                newOrderForm = new NewOrderForm();
            }
            newOrderForm.Show();
        }

        private void btnProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            ProductsForm productsForm;
            if (ContainsKey("ProductsForm"))
            {
                productsForm = Application.OpenForms["ProductsForm"] as ProductsForm;
                productsForm.Show();
            }
            else
            {
                productsForm = new ProductsForm();
            }
            productsForm.Show();
        }

        private void btnOrder_Click(object sender, EventArgs e)
        {
            this.Hide();
            OrdersForm ordersForm;
            if (ContainsKey("OrdersForm"))
            {
                ordersForm = Application.OpenForms["OrdersForm"] as OrdersForm;
                ordersForm.Show();
            }
            else
            {
                ordersForm = new OrdersForm();
            }
            ordersForm.Show();
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            this.Hide();
            LoginForm loginForm;
            if (ContainsKey("LoginForm"))
            {
                loginForm = Application.OpenForms["LoginForm"] as LoginForm;
                loginForm.Show();
            }
            else
            {
                loginForm = new LoginForm(customerServices);
            }
            loginForm.Show();
        }

        private bool ContainsKey(string formName)
        {
            bool isHomeFormOpen = false;

            foreach (Form form in Application.OpenForms)
            {
                if (form.Name == formName)
                {
                    isHomeFormOpen = true;
                    break;
                }
            }

            return isHomeFormOpen;
        }
    }
}
