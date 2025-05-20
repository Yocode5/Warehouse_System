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

namespace Warehouse_System
{
    public partial class productNames : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True");

        public productNames()
        {
            InitializeComponent();
        }



        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void productNames_Load(object sender, EventArgs e)
        {

            load_accessories();
            load_suppliers();
            load_Products();
        }

        private void load_accessories()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT AccessoryId, AccessoryName FROM Accessories", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            SelectUnit.DataSource = dt;
            SelectUnit.DisplayMember = "AccessoryName";
            SelectUnit.ValueMember = "AccessoryId";
        }

        private void load_suppliers()
        {
            SqlDataAdapter da = new SqlDataAdapter("SELECT SupplierId, SupplierName FROM Supplier", con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBox1.DataSource = dt;
            comboBox1.DisplayMember = "SupplierName";
            comboBox1.ValueMember = "SupplierId";
        }

        private void load_Products() {
            string query = @"
                        SELECT 
                            p.ProductId,
                            p.ProductName,
                            a.AccessoryName,
                            s.SupplierName,
                            p.Product_Quantity
                        FROM
                            Products p
                        JOIN
                            Accessories a ON p.AccessoryId = a.AccessoryId
                        JOIN
                            Supplier s ON p.SupplierId = s.SupplierId";

            SqlDataAdapter da = new SqlDataAdapter(query, con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || string.IsNullOrWhiteSpace(textBox1.Text))
            {
                MessageBox.Show("Please Enter All the Details. ");
                return;
            }

            string query = "INSERT INTO Products (ProductName, AccessoryId, SupplierId, Product_Quantity) VALUES (@name, @accessoryId, @supplierId, @quantity)";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@name", textBox1.Text);
            cmd.Parameters.AddWithValue("@accessoryId", SelectUnit.SelectedValue);
            cmd.Parameters.AddWithValue("@supplierId", comboBox1.SelectedValue);
            cmd.Parameters.AddWithValue("@quantity", Convert.ToInt32(textBox2.Text));

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("New Record created successfully.");
            load_Products();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0 || dataGridView1.SelectedRows[0].Cells["ProductId"].Value == null)
            {
                MessageBox.Show("Please select a product to delete. ");
                return;
            }

            int productId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["ProductId"].Value);
            string query = "DELETE FROM Products WHERE ProductId = @id";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@id", productId);

            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();

            MessageBox.Show("Product succssfully deleted.");
            load_Products();
        }
    }
}
