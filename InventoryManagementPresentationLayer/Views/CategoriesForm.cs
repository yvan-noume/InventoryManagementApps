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
    public partial class CategoriesForm : BaseForm
    {
        public CategoriesForm()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            HomeForm homeForm = Application.OpenForms["HomeForm"] as HomeForm;
            homeForm.Show();
        }
    }
}
