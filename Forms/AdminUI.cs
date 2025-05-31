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
    public partial class AdminUI: Form
    {
        public AdminUI()
        {
            InitializeComponent();
        }

        

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BackToLogin_Click(object sender, EventArgs e)
        {
            this.Hide();
            new LoginForm().ShowDialog();
            this.Close();
        }

        private void ManageEmployee_Click(object sender, EventArgs e)
        {
            this.Hide();
            new EmployeeForm().ShowDialog();
            this.Close();
        }

        private void ManageBranches_Click(object sender, EventArgs e)
        {
            this.Hide();
            new BranchForm().ShowDialog();
            this.Close();
        }

        private void ManageSuppliers_Click(object sender, EventArgs e)
        {
            this.Hide();
            new SupplierForm().ShowDialog();
            this.Close();
        }
    }
}
