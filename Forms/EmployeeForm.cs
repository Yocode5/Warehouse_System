using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Warehouse_System.DataAccess;
using Warehouse_System.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Security.Cryptography;

namespace Warehouse_System.Forms
{
    public partial class EmployeeForm : Form
    {
        private EmployeeDA _employeeDA;
        public EmployeeForm()
        {
            InitializeComponent();

            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Warehouse_DB.mdf;Integrated Security=True";
            _employeeDA = new EmployeeDA(conString);
        }

        private void EmployeeForm_Load(object sender, EventArgs e)
        {
            LoadEmployee();
            LoadComboBoxes();
            panelEUpdate.Visible = false;
            textBoxUEPw.Visible = false;
        }

        private void LoadComboBoxes()
        {
            comboBoxEPosition.DataSource = _employeeDA.LoadPositions();
            comboBoxEPosition.DisplayMember = "PositionName";
            comboBoxEPosition.ValueMember = "PositionId";

            comboBoxUEPosition.DataSource = _employeeDA.LoadPositions();
            comboBoxUEPosition.DisplayMember = "PositionName";
            comboBoxUEPosition.ValueMember = "PositionId";
        }

        private void LoadEmployee()
        {
            try
            {
                dataGridViewEmployee.DataSource = _employeeDA.GetEmployees();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error: {ex.Message}");
            }
        }

        private void buttonEInsert_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxEId.Text) ||
            string.IsNullOrWhiteSpace(textBoxEFName.Text) ||
            string.IsNullOrWhiteSpace(textBoxELName.Text) ||
            (comboBoxEPosition.SelectedIndex == -1) ||
            string.IsNullOrWhiteSpace(textBoxEEmail.Text) ||
            string.IsNullOrWhiteSpace(textBoxEUsername.Text) ||
            string.IsNullOrWhiteSpace(textBoxEPw.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                Employee employee = new Employee
                {
                    EmployeeId = Convert.ToInt32(textBoxEId.Text),
                    FirstName = textBoxEFName.Text,
                    LastName = textBoxELName.Text,
                    PositionId = Convert.ToInt32(comboBoxEPosition.SelectedValue),
                    Email = textBoxEEmail.Text,
                    UserName = textBoxEUsername.Text,
                    Password = HashPassword(textBoxEPw.Text)
                };

                _employeeDA.AddEmployee(employee);
                ClearInsertFields();
                LoadEmployee();
                MessageBox.Show("Record Inserted Successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to insert the record. Error: " + ex.Message);
            }
        }

        private void ClearInsertFields()
        {
            textBoxEId.Clear();
            textBoxEFName.Clear();
            textBoxELName.Clear();
            comboBoxEPosition.SelectedIndex = 0;
            textBoxEEmail.Clear();
            textBoxEUsername.Clear();
            textBoxEPw.Clear();
        }

        private void buttonEUpdateSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewEmployee.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Please select a row to update");
                    return;
                }

                panelEUpdate.Visible = true;
                DataGridViewRow row = dataGridViewEmployee.SelectedRows[0];

                textBoxUEId.Text = row.Cells["EmployeeId"].Value.ToString();
                textBoxUEFName.Text = row.Cells["FirstName"].Value.ToString();
                textBoxUELName.Text = row.Cells["LastName"].Value.ToString();
                comboBoxUEPosition.SelectedValue = row.Cells["PositionId"].Value.ToString();
                textBoxUEEmail.Text = row.Cells["Email"].Value.ToString();
                textBoxUEUsername.Text = row.Cells["UserName"].Value.ToString();

                textBoxUEPw.Clear();
                textBoxUEPw.Visible = false;
                checkBoxChangePw.Checked = false;
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occured while loading the selected record to update: " + ex.Message);
            }
        }

        private void buttonEUpdate_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxUEFName.Text) ||
            string.IsNullOrWhiteSpace(textBoxUELName.Text) ||
            (comboBoxUEPosition.SelectedIndex == -1) ||
            string.IsNullOrWhiteSpace(textBoxUEEmail.Text) ||
            string.IsNullOrWhiteSpace(textBoxUEUsername.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                Employee updatedEmployee = new Employee
                {
                    EmployeeId = Convert.ToInt32(textBoxUEId.Text),
                    FirstName = textBoxUEFName.Text,
                    LastName = textBoxUELName.Text,
                    PositionId = Convert.ToInt32(comboBoxUEPosition.SelectedValue),
                    Email = textBoxUEEmail.Text,
                    UserName = textBoxUEUsername.Text
                };

                if (checkBoxChangePw.Checked==true)
                {
                    updatedEmployee.Password = HashPassword(textBoxUEPw.Text);
                    if(string.IsNullOrWhiteSpace(textBoxUEPw.Text))
                    {
                        MessageBox.Show("Please fill all fields.");
                        return;
                    }
                }
                else
                {
                    updatedEmployee.Password = _employeeDA.GetPasswordByEmployeeId(updatedEmployee.EmployeeId);
                }

                _employeeDA.UpdateEmployee(updatedEmployee);
                LoadEmployee();
                panelEUpdate.Visible = false;
                MessageBox.Show("Record Updated Successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to update the record. Error: " + ex.Message);
            }
        }

        private void buttonEDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewEmployee.SelectedRows.Count > 0)
                {
                    int id = Convert.ToInt32(dataGridViewEmployee.SelectedRows[0].Cells["EmployeeId"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete selected employee?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            _employeeDA.DeleteEmployee(id);
                            LoadEmployee();
                            MessageBox.Show("Record Deleted Successfully!");
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Delete failed: " + ex.Message);
                        }
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

        private void BackToDashboard_Click(object sender, EventArgs e)
        {
            this.Hide();
            new AdminUI().ShowDialog();
            this.Close();
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

        private void checkBoxChangePw_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUEPw.Visible = checkBoxChangePw.Checked;
        }
    }
}
