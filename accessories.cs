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

namespace Warehouse_System
{
    public partial class accessories : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True");
        public accessories()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Please enter an accessory name.");
                    return;
                }
                using (SqlCommand acc = con.CreateCommand())
                {
                    acc.CommandType = CommandType.Text;
                    acc.CommandText = "Insert into Accessories (AccessoryName)VALUES (@accessory)";
                    acc.Parameters.AddWithValue("@accessory", textBox1.Text.Trim());
                    acc.ExecuteNonQuery();
                }
                MessageBox.Show("Accessory added succsessfully");
                textBox1.Clear();
                disp();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Insert error:" + ex.Message);
            }

        }

        private void accessories_Load(object sender, EventArgs e)
        {
            try
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
                con.Open();
                disp();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection error : " + ex.Message);
            }
        }
        public void disp()
        {
            try
            {
                SqlCommand acc = con.CreateCommand();
                acc.CommandType = CommandType.Text;
                acc.CommandText = "select * from Accessories";
                acc.ExecuteNonQuery();
                DataTable adt = new DataTable();
                SqlDataAdapter ada = new SqlDataAdapter(acc);
                ada.Fill(adt);
                dataGridView1.DataSource = adt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("display error:" + ex.Message);


            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AccessoryId"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this accessory?","Confirm Delete", MessageBoxButtons.YesNo , MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes) {
                        using (SqlCommand acc = con.CreateCommand())
                        {
                            acc.CommandType = CommandType.Text;
                            acc.CommandText = "DELETE FROM Accessories WHERE AccessoryId = @id";
                            acc.Parameters.AddWithValue("@id", selectedId);
                            acc.ExecuteNonQuery();
                        }
                        MessageBox.Show("Accessory deleted successfully");
                        disp();
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete eror: " + ex.Message);
            }

        }
    }
}

    

