using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_System.DataAccess;
using Warehouse_System.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Warehouse_System
{
    public partial class DispatchForm: Form
    {
        private readonly DispatchDA dispatchDA;
        private string source;

        public DispatchForm(string source)
        {
            InitializeComponent();
            dispatchDA = new DispatchDA();
            LoadBranches();
            LoadProducts();
            this.source = source;
        }

        //Load the Brnach information using the DA files
        private void LoadBranches()
        {
            try
            {
                comboBox1.DataSource = dispatchDA.GetAllBranches();
                comboBox1.DisplayMember = "BranchName";
                comboBox1.ValueMember = "BranchId";
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Loading Branches: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                comboBox2.DataSource = dispatchDA.GetAllProducts();
                comboBox2.DisplayMember = "ProductName";
                comboBox2.ValueMember = "ProductId";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Products: " + ex.Message);
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1 || comboBox2.SelectedIndex == -1 || string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            if (!int.TryParse(textBox3.Text, out int dispatchQTY) || dispatchQTY <= 0)
            {
                MessageBox.Show("Enter a Valid quantity greater than 0");
                return;
            }

            int branchId = Convert.ToInt32(comboBox1.SelectedValue);
            int productId = Convert.ToInt32(comboBox2.SelectedValue);
            DateTime dispatchDate = dateTimePicker1.Value;

            try
            {

                int currentStock = Convert.ToInt32(dispatchDA.GetProductsStock(productId));

                if (dispatchQTY > currentStock)
                {
                    MessageBox.Show("Not enough Stock Avaliable");
                    return;
                }

                Dispatch dispatch = new Dispatch
                {
                    BranchId = branchId,
                    ProductId = productId,
                    Quantity = dispatchQTY,
                    DispatchDate = dispatchDate
                };

                dispatchDA.InsertDispatch(dispatch);
                dispatchDA.UpdateStock(productId, dispatchQTY);

                textBox3.Clear();
                comboBox1.SelectedIndex = 0;
                comboBox2.SelectedIndex = 0;
                MessageBox.Show("Items Successfully Dispatched.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error While dispatching: " + ex.Message);
            }
        }

        private void BackToDashboard_Click(object sender, EventArgs e)
        {
            if (source == "manager")
            {
                this.Hide();
                new WarehouseManagerUI().ShowDialog();
                this.Close();
            }

            else if (source == "staff")
            {
                this.Hide();
                new WarehouseStaffUI().ShowDialog();
                this.Close();
            }
            this.Close();
        }
    }
}
