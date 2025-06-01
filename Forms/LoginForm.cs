using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_System.DataAccess;
using Warehouse_System.Models;

namespace Warehouse_System
{
    public partial class LoginForm: Form
    {

        private readonly string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True";
        
        public LoginForm()
        {
            InitializeComponent();
            textBox2.PasswordChar = '●';
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string username = textBox1.Text.Trim();
            string password = textBox2.Text.Trim();

            if ( string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                MessageBox.Show("Please enter both username and password.");
                return;
            }

            LoginModel loginModel = new LoginModel
            {
                UserName = username,
                Password = HashPassword(password)
            }; 

            try
            {
                LoginDA loginDA = new LoginDA(conString);
                int? positionID = loginDA.ValidateUser(loginModel);

                if (positionID != null)
                {
                    this.Hide();

                    switch (positionID)
                    {
                        case 1:
                            new AdminUI().ShowDialog();
                            break;
                        case 2:
                            new WarehouseManagerUI().ShowDialog();
                            break;
                        case 3:
                            new WarehouseStaffUI().ShowDialog();
                            break;
                    }

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid Username or Password");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return BitConverter.ToString(hash).Replace("-", "").ToLower();
            }
        }
    }
}
