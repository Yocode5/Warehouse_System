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
    public partial class supplier : Form
    {
        SqlConnection con=new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True");
        public supplier()
        {
            InitializeComponent();
        }

        private void buttonSInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "INSERT INTO Supplier VALUES ('" + textBoxSId.Text + "','" + textBoxSName.Text + "','" + textBoxSPhone.Text + "','" + textBoxSEmail.Text + "','" + textBoxSAddress.Text + "')";
                cmd.ExecuteNonQuery();

                textBoxSId.Text = "";
                textBoxSName.Text = "";
                textBoxSPhone.Text = "";
                textBoxSEmail.Text = "";
                textBoxSAddress.Text = "";

                DisplaySupplier();
                MessageBox.Show("Record Inserted Successfully!");
            }

            catch(Exception ex) 
            {
                MessageBox.Show("Unable to insert the record. Error: "+ex.Message);
            }
        }

        private void supplier_Load(object sender, EventArgs e)
        {
            try 
            {
                if (con.State == System.Data.ConnectionState.Open)
                {
                    con.Close();
                }
                con.Open();

                DisplaySupplier();
                panelSUpdate.Visible = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occured while connecting to the database: " + ex.Message);
            }
        }

        public void DisplaySupplier()
        {
            try
            {
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Supplier";
                cmd.ExecuteNonQuery();
                DataTable supplierTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(supplierTable);
                dataGridViewSupplier.DataSource = supplierTable;
            }
            catch (Exception ex)
            {

                MessageBox.Show("Can not display the table due to an unexpected error: " + ex.Message);
            }
        }
        private void buttonSUpdateSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSupplier.SelectedCells.Count==0)
                {
                    MessageBox.Show("Please select a row to update");
                    return;
                }
                
                panelSUpdate.Visible = true;
                int id = Convert.ToInt32(dataGridViewSupplier.SelectedCells[0].Value.ToString());

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "SELECT * FROM Supplier WHERE SupplierId=" + id + "";
                cmd.ExecuteNonQuery();
                DataTable supplierTable = new DataTable();
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(supplierTable);

                foreach (DataRow dr in supplierTable.Rows)
                {
                    textBoxUSId.Text = dr["SupplierId"].ToString();
                    textBoxUSName.Text = dr["SupplierName"].ToString();
                    textBoxUSPhone.Text = dr["SupplierPhone"].ToString();
                    textBoxUSEmail.Text = dr["SupplierEmail"].ToString();
                    textBoxUSAddress.Text = dr["SupplierAddress"].ToString();
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occured while loading the selected record to update: " + ex.Message);
            }
        }

        private void buttonSUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                int id = Convert.ToInt32(dataGridViewSupplier.SelectedCells[0].Value.ToString());

                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = "UPDATE Supplier SET SupplierName='" + textBoxUSName.Text + "',SupplierPhone='" + textBoxUSPhone.Text + "',SupplierEmail='" + textBoxUSEmail.Text + "',SupplierAddress='" + textBoxUSAddress.Text + "' WHERE SupplierId=" + id + "";
                cmd.ExecuteNonQuery();

                panelSUpdate.Visible = false;
                DisplaySupplier();

                MessageBox.Show("Record Updated Successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to update the record. Error: " + ex.Message);
            }
        }

        private void buttonSDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSupplier.SelectedRows.Count > 0)
                {
                    if (con.State != ConnectionState.Open)
                    {
                        con.Open();
                    }

                    int id = Convert.ToInt32(dataGridViewSupplier.SelectedCells[0].Value.ToString());

                    DialogResult result = MessageBox.Show("Are you sure you want to delete selected supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        SqlCommand cmd = con.CreateCommand();
                        cmd.CommandType = CommandType.Text;
                        cmd.CommandText = "DELETE FROM Supplier WHERE SupplierId=" + id + "";
                        cmd.ExecuteNonQuery();

                        DisplaySupplier();
                        MessageBox.Show("Record Deleted Successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("Please select a row to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to delete the record. Error: " + ex.Message);
            }
        }
    }
}
