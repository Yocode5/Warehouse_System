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
    public partial class DispatchItems: Form
    {
        //Connection string (replace data source )
        private string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True";

        public DispatchItems()
        {
            InitializeComponent();
            LoadBranches();
            LoadProducts();
        }

        private void LoadBranches()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = "SELECT BranchId, BranchName FROM Branch";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox1.DataSource = dt;
                    comboBox1.DisplayMember = "BranchName";
                    comboBox1.ValueMember = "BranchId";
                }
            }
            catch (Exception ex) 
            {
                MessageBox.Show("Error Loadig Brnaches: " + ex.Message);
            }
        }

        private void LoadProducts()
        {
            try
            {
                using (SqlConnection con = new SqlConnection(conString))
                {
                    string query = "SELECT ProductId, ProductName FROM Products";
                    SqlDataAdapter da = new SqlDataAdapter(query, con);
                    DataTable dt = new DataTable();
                    da.Fill(dt);

                    comboBox2.DataSource = dt;
                    comboBox2.DisplayMember = "ProductName";
                    comboBox2.ValueMember = "ProductId";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loadig Products: " + ex.Message);
            }
        }

        private void DispatchItems_Load(object sender, EventArgs e)
        {

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
                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();

                    //Check Current Stock
                    string checkStockQuery = "SELECT Product_Quantity FROM Products WHERE ProductId = @ProductId";
                    SqlCommand checkCmd = new SqlCommand(checkStockQuery, con);
                    checkCmd.Parameters.AddWithValue("@ProductId", productId);
                    int currentStock = Convert.ToInt32(checkCmd.ExecuteScalar());

                    if (dispatchQTY > currentStock)
                    {
                        MessageBox.Show("Not enough Stock Avaliable");
                        return;
                    }

                    string insertQuery = @"INSERT INTO Dispatch_Master (BranchId, ProductId, QTY, DispatchDate) VALUES (@BRanchId, @ProductId, @QTY, @DispatchDate)";

                    SqlCommand insertCmd = new SqlCommand(insertQuery, con);
                    insertCmd.Parameters.AddWithValue("@BranchId", branchId);
                    insertCmd.Parameters.AddWithValue("@ProductId", productId);
                    insertCmd.Parameters.AddWithValue("@QTY", dispatchQTY);
                    insertCmd.Parameters.AddWithValue("@DispatchDate", dispatchDate);
                    insertCmd.ExecuteNonQuery();

                    string updateQuery = "UPDATE Products SET Product_Quantity = Product_Quantity - @QTY WHERE ProductId = @ProductId";
                    SqlCommand updateCmd = new SqlCommand(updateQuery, con);
                    updateCmd.Parameters.AddWithValue("@QTY", dispatchQTY);
                    updateCmd.Parameters.AddWithValue("@ProductId", productId);
                    updateCmd.ExecuteNonQuery();

                    MessageBox.Show("Items Successfully Dispatched.");
                    textBox3.Clear();
                }
            } 
            
            catch (Exception ex)
            {
                MessageBox.Show("Error While dispatching: " + ex.Message);
            }
        }
    }
}
