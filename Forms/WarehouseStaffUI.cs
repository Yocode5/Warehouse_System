using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_System.Forms;

namespace Warehouse_System
{
    public partial class WarehouseStaffUI: Form
    {
        public WarehouseStaffUI()
        {
            InitializeComponent();
        }

        private void RestockItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductRestockForm("staff").ShowDialog();
            this.Close();
        }

        private void DispatchItems_Click(object sender, EventArgs e)
        {
            this.Hide();
            new DispatchForm("staff").ShowDialog();
            this.Close();
        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void buttonViewProducts_Click(object sender, EventArgs e)
        {
            this.Hide();
            new ProductDetailsForm().ShowDialog();
            this.Close();
        }
    }
}
