using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_System.Models;
using Warehouse_System.DataAccess;

namespace Warehouse_System.Forms
{
    public partial class ProductRestockForm : Form
    {
        private string source;
        private ProductRestockDA restockRepo = new ProductRestockDA();
        public ProductRestockForm(string source)
        {
            InitializeComponent();
            this.source = source;
        }

        private void ProductRestockForm_Load(object sender, EventArgs e)
        {
            LoadComboBoxes();
        }

        private void LoadComboBoxes()
        {
            comboBox1.DataSource = restockRepo.LoadProducts();
            comboBox1.DisplayMember = "ProductName";
            comboBox1.ValueMember = "ProductId";

            comboBox2.DataSource = restockRepo.LoadSuppliers();
            comboBox2.DisplayMember = "SupplierName";
            comboBox2.ValueMember = "SupplierId";

            comboBox3.DataSource = restockRepo.LoadAccessories();
            comboBox3.DisplayMember = "AccessoryName";
            comboBox3.ValueMember = "AccessoryId";
        }

        private void buttonRestock_Click(object sender, EventArgs e)
        {
            // Validating the Inputs
            if (comboBox1.SelectedIndex == -1 ||
                comboBox2.SelectedIndex == -1 ||
                comboBox3.SelectedIndex == -1 ||
                string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields correctly");
                return;
            }

            // Validating the Quantity
            if (!int.TryParse(textBox1.Text, out int restockQty) || restockQty <= 0)
            {
                MessageBox.Show("Quantity must be a Positive Number");
                return;
            }

            try
            {
                // Create and populate the model
                ProductRestock restock = new ProductRestock
                {
                    ProductId = Convert.ToInt32(comboBox1.SelectedValue),
                    SupplierId = Convert.ToInt32(comboBox2.SelectedValue),
                    AccessoryId = Convert.ToInt32(comboBox3.SelectedValue),
                    Quantity = restockQty,
                    RestockDate = dateTimePicker1.Value
                };

                // Call the data access method
                restockRepo.RestockProduct(restock);

                // Optional: clear form after restock
                ClearFields();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error during restock: " + ex.Message);
            }
        }

        private void ClearFields()
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
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
