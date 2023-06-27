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
    public partial class OrdersForm : BaseForm
    {
        public OrdersForm()
        {
            InitializeComponent();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = Application.OpenForms["HomeForm"] as HomeForm;
            homeForm.Show();
        }
    }
}
