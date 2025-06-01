using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.CodeDom.Compiler;
using Org.BouncyCastle.X509.Store;
using System.Windows.Forms.VisualStyles;
using Warehouse_System.DataAccess;
using Warehouse_System.Models;

namespace Warehouse_System
{
    public partial class ProductForm : Form
    {
        private readonly ProductDA productDA;
        public ProductForm()
        {
            InitializeComponent();
            productDA = new ProductDA();
        }
        private void productNames_Load(object sender, EventArgs e)
        {

            load_accessories();
            load_suppliers();
            load_Products();
        }

        private void load_accessories()
        {
            DataTable dt = productDA.GetAccessories();
            SelectUnit.DataSource = dt;
            SelectUnit.DisplayMember = "AccessoryName";
            SelectUnit.ValueMember = "AccessoryId";
        }

        private void load_suppliers()
        {
            DataTable dt = productDA.GetSuppliers();
            comboBoxSupplier.DataSource = dt;
            comboBoxSupplier.DisplayMember = "SupplierName";
            comboBoxSupplier.ValueMember = "SupplierId";
        }

        private void load_Products() {

            DataTable dt = productDA.GetAllProducts();
            dataGridView1.DataSource = dt;

            //Low stock Threshold
            int lowStockThreshold = 5;
            bool lowStockFound = false;
            StringBuilder lowStockProducts = new StringBuilder();

            //Moderate stock Threshold
            int midStockThreshold = 15;

            //IChecking each row and highlight if Quantity is low
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                //Outtracking the Last row used to add items
                if (row.IsNewRow) continue;

                if (row.Cells["Product_Quantity"].Value != DBNull.Value)
                {
                    int quantity = Convert.ToInt32(row.Cells["Product_Quantity"].Value);
                    if (quantity < midStockThreshold)
                    {
                        row.DefaultCellStyle.BackColor = Color.DarkOrange;
                        row.DefaultCellStyle.ForeColor = Color.White;
                    }

                    if (quantity < lowStockThreshold)
                    {
                        row.DefaultCellStyle.BackColor = Color.Red;
                        row.DefaultCellStyle.ForeColor = Color.White;

                        lowStockFound = true;
                        lowStockProducts.AppendLine($" {row.Cells["ProductName"].Value} (QTY: {quantity})");
                    }
                }
            }

            //Message alert if low stock found 
            if (lowStockFound)
            {
                MessageBox.Show(
                    "The following items in the warehouse are low on stock:\n\n" + lowStockProducts.ToString() + "\n Consider Restocking to prevent any outage.",
                    "Low Stock Alert",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning
                    );
            }
        }
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxPName.Text) || string.IsNullOrWhiteSpace(textBoxPName.Text))
            {
                MessageBox.Show("Please Enter All the Details. ");
                return;
            }

            try
            {
                Product product = new Product()
                {

                    ProductName = textBoxPName.Text,
                    AccessoryId = Convert.ToInt32(SelectUnit.SelectedValue),
                    SupplierId = Convert.ToInt32(comboBoxSupplier.SelectedValue),
                    ProductQuantity = Convert.ToInt32(textBoxQTY.Text)
                };

                productDA.AddProduct(product);
                load_Products();
                textBoxPName.Clear();
                SelectUnit.SelectedIndex = 0;
                comboBoxSupplier.SelectedIndex = 0;
                textBoxQTY.Clear();
                MessageBox.Show("New Record Created Successfully");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Add Product: " + ex.Message);
            }
        }
        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows[0].Cells["ProductId"].Value == null)
            {
                MessageBox.Show("Please select a product to delete. ");
                return;
            }

            int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProductId"].Value);
            productDA.DeleteProduct(productId);

            load_Products();
            MessageBox.Show("Product succssfully deleted.");
        }

        private void BackToDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WarehouseManagerUI().ShowDialog();
            this.Close();
        }
    }
}
