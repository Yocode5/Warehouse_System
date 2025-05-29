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
    public partial class Login: Form
    {

        private string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True";
        
        public Login()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            using (SqlConnection con = new SqlConnection(conString))
            {
                string query = "SELECT PositionID FROM Employee WHERE UserName = @username AND Password = @password";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@username", username);
                cmd.Parameters.AddWithValue("@password", password);

                try
                {
                    con.Open();
                    object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        int positionID = Convert.ToInt32(result);

                       

                        if (positionID == 1)
                        {
                            this.Hide();
                            var adminForm = new AdminUI();
                            adminForm.FormClosed += (s, args) => this.Close();
                            adminForm.Show();
                        }
                        else if (positionID == 2)
                        {
                            this.Hide();
                            var WarehouseManagerForm = new WarehouseManagerUI();
                            WarehouseManagerForm.FormClosed += (s, args) => this.Close();
                            WarehouseManagerForm.Show();
                        }
                        else if (positionID == 3)
                        {
                            this.Hide();
                            var WarehouseStaffForm = new WarehouseStaffUI();
                            WarehouseStaffForm.FormClosed += (s, args) => this.Close();
                            WarehouseStaffForm.Show();
                        }
                        else
                        {
                            MessageBox.Show("Unknown role.");
                            this.Show();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password.");
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
