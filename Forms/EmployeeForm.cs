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

namespace Warehouse_System.Forms
{
    public partial class EmployeeForm : Form
    {
        private EmployeeDA _employeeDA = new EmployeeDA();
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
                    Password = textBoxEPw.Text
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
                textBoxUEPw.Text = row.Cells["Password"].Value.ToString();
            }

            catch (Exception ex)
            {
                MessageBox.Show("Error occured while loading the selected record to update: " + ex.Message);
            }
        }

        private void buttonEUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                Employee updatedEmployee = new Employee
                {
                    EmployeeId = Convert.ToInt32(textBoxUEId.Text),
                    FirstName = textBoxUEFName.Text,
                    LastName = textBoxUELName.Text,
                    PositionId = Convert.ToInt32(comboBoxUEPosition.SelectedValue),
                    Email = textBoxUEEmail.Text,
                    UserName = textBoxUEUsername.Text,
                    Password = textBoxUEPw.Text,
                };

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

                    DialogResult result = MessageBox.Show("Are you sure you want to delete selected supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
    }
}
