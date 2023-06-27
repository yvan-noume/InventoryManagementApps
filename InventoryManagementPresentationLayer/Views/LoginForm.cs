using InventoryManagementApplicationLayer.API;
using InventoryManagementApplicationLayer.Services;
using InventoryManagementPresentationLayer.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InventoryManagementPresentationLayer.Views
{
    public partial class LoginForm : BaseForm
    {
        private LoginViewModel loginViewModel;
        private HomeForm homeForm;

        public LoginForm(ICustomerServices customerService)
        {
            InitializeComponent();
            //homeForm = new HomeForm(customerService);
            //loginViewModel = new LoginViewModel();
            //txtUsername.DataBindings.Add("Text", loginViewModel, "Username", false, DataSourceUpdateMode.OnPropertyChanged);
            //txtPassword.DataBindings.Add("Text", loginViewModel, "Password", false, DataSourceUpdateMode.OnPropertyChanged);
            //lbError.DataBindings.Add("Text", loginViewModel, "ErrorMessage", false, DataSourceUpdateMode.OnPropertyChanged);
            ////txtUsername.DataBindings.Add("Text", txtPassword, "Text");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //loginViewModel.Login();
            homeForm.Show();
        }
    }
}
