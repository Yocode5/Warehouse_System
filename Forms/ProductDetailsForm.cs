using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_System.DataAccess;

namespace Warehouse_System.Forms
{
    public partial class ProductDetailsForm : Form
    {
        private readonly ProductDA productDA;
        public ProductDetailsForm()
        {
            InitializeComponent();
            productDA = new ProductDA();
        }

        private void ProductDetails_Load(object sender, EventArgs e)
        {
            load_accessories();
            load_suppliers();
            load_Products();
        }

        private void load_accessories()
        {
            DataTable dt = productDA.GetAccessories();
        }

        private void load_suppliers()
        {
            DataTable dt = productDA.GetSuppliers();
        }

        private void load_Products()
        {
            try
            {
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
            catch (Exception ex) 
            {
                MessageBox.Show($"Error loading the products: {ex.Message}");
            }
        }

        private void BackToDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new WarehouseStaffUI().ShowDialog();
            this.Close();
        }
    }
}
