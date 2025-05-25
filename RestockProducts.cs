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

namespace Warehouse_System
{
    public partial class RestockProducts: Form
    {
        //Connection String
        private string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True";

        public RestockProducts()
        {
            InitializeComponent();
            LoadProducts();
            LoadSuppliers();
            LoadAccessories();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void RestockProducts_Load(object sender, EventArgs e)
        {

        }

        //Loading the Products Into the Combobox
        private void LoadProducts()
        {
            try {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    //Opens a Connection
                    con.Open();
                    string query = "SELECT ProductId, ProductName FROM Products";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "ProductName";
                    comboBox1.ValueMember = "ProductId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading products: " + ex.Message);
            }
        }

        //Loading Suppliers to Comboboxes
        private void LoadSuppliers()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    //Opens a Connection
                    con.Open();
                    string query = "SELECT SupplierId, SupplierName From Supplier";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "SupplierName";
                    comboBox2.ValueMember = "SupplierId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Suppliers: " + ex.Message);
            }
        }

        private void LoadAccessories()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    //Opens a Connection
                    con.Open();
                    string query = "SELECT AccessoryId, AccessoryName FROM Accessories";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox3.DataSource = dt;
                    comboBox3.DisplayMember = "AccessoryName";
                    comboBox3.ValueMember = "AccessoryId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Accessories: " + ex.Message);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Validating the Inputs
            if (comboBox1.SelectedIndex == -1 || 
                comboBox2.SelectedIndex == -1 ||
                comboBox3.SelectedIndex == -1 ||
                string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Please fill in all fields correctly");
                return;
            }

            //Validating the Quantity
            if (!int.TryParse(textBox1.Text, out int restockQty) || restockQty <= 0)
            {
                MessageBox.Show("Quantity must be a Positive Number");
                return;
            }

            //Get the Selected values
            int productId = Convert.ToInt32(comboBox1.SelectedValue);
            int supplierId = Convert.ToInt32(comboBox2.SelectedValue);
            int accessoryId = Convert.ToInt32(comboBox3.SelectedValue);
            DateTime restockDate = dateTimePicker1.Value;

            //DB operations
            using (SqlConnection con = new SqlConnection(conString))
            {
                //Opening a connection
                con.Open();
                SqlTransaction transaction = con.BeginTransaction();

                try
                {
                    //Inseting Data into RestockMaster (Logging)
                    string insertQuery = @"INSERT INTO Restock_Master (ProductId, QTY, SupplierId, AccessoryId, RestockDate) VALUES (@ProductId, @QTY, @SupplierId, @AccessoryId, @RestockDate)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, con, transaction);
                    insertCmd.Parameters.AddWithValue("@ProductId", productId);
                    insertCmd.Parameters.AddWithValue("@QTY", restockQty);
                    insertCmd.Parameters.AddWithValue("@SupplierId", supplierId);
                    insertCmd.Parameters.AddWithValue("@AccessoryId", accessoryId);
                    insertCmd.Parameters.AddWithValue("@RestockDate", restockDate);
                    insertCmd.ExecuteNonQuery();

                    //Updating (Incrementing) Product Quantity
                    string updateQuery = @"UPDATE Products SET Product_Quantity = Product_Quantity + @QTY WHERE ProductId = @ProductId";

                    SqlCommand updateCmd = new SqlCommand(updateQuery, con, transaction);
                    updateCmd.Parameters.AddWithValue("@QTY", restockQty);
                    updateCmd.Parameters.AddWithValue("@ProductId", productId);
                    updateCmd.ExecuteNonQuery();

                    //Submit if Successful
                    transaction.Commit();
                    MessageBox.Show("Items Successfully Restocked");

                    //Clear Fields after Submission
                    ClearFields();
                }
                catch (Exception ex)
                {
                    transaction.Rollback(); // Rollback an Error
                    MessageBox.Show("Restock Process Failed: " + ex.Message);
                }
            }
        }

        //Clear the Fields 
        private void ClearFields()
        {
            textBox1.Clear();
            comboBox1.SelectedIndex = 0;
            comboBox2.SelectedIndex = 0;
            comboBox3.SelectedIndex = 0;
            dateTimePicker1.Value = DateTime.Now;
        }
    }
}
