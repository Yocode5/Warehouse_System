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
using Warehouse_System.DataAccess;
using Warehouse_System.Models;

namespace Warehouse_System.Forms
{
    public partial class BranchForm: Form
    {
        private readonly BranchDA branchDA;

        public BranchForm()
        {
            InitializeComponent();
            string conString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True";
            branchDA = new BranchDA(conString);
        }

        private void BranchForm_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            dataGridView1.DataSource = branchDA.GetAllBranches();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBox1.Text) || 
                string.IsNullOrWhiteSpace(textBox2.Text) || 
                string.IsNullOrWhiteSpace(textBox3.Text))
            {
                MessageBox.Show("Please fill all fields.");
                return;
            }

            try
            {
                Branch newBranch = new Branch
                {
                    BranchName = textBox1.Text,
                    Location = textBox2.Text,
                    ContactNo = textBox3.Text
                };

                branchDA.AddBranch(newBranch);
                MessageBox.Show("Branch Added Successfully");
                LoadData();

                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Loading Branch: " + ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                try
                {
                    int branchId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["BranchId"].Value);
                    branchDA.DeleteBranch(branchId);
                    MessageBox.Show("Branch Deleted Successfully");
                    LoadData();
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Error Deleting Branch: " + ex.Message);
                }
            }
            else
            {
                MessageBox.Show("Please select a row to delete");
            }
        }
    }
}
