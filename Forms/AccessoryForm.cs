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
using Warehouse_System.DataAccess;
using Warehouse_System.Models;

namespace Warehouse_System
{
    public partial class AccessoryForm : Form
    {
        private readonly AccessoryDA _accessoryDAL;
        public AccessoryForm()
        {
            InitializeComponent();

            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Warehouse_DB.mdf;Integrated Security=True";
            _accessoryDAL = new AccessoryDA(conString);
        }

        private void AccessoriesForm_Load(object sender, EventArgs e)
        {
            LoadAccessories();
        }

        private void LoadAccessories()
        {
            try
            {
                dataGridView1.DataSource = _accessoryDAL.GetAccessories();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error {ex.Message}");
            }
        }

        private void buttonAddAcc_Click(object sender, EventArgs e)
        {

            try
            {
                if (string.IsNullOrWhiteSpace(textBoxAccName.Text))
                {
                    MessageBox.Show("Please enter an accessory name.");
                    return;
                }


                Accessory accessory = new Accessory
                {
                    AccessoryName = textBoxAccName.Text.Trim(),
                };

                _accessoryDAL.AddAccessory(accessory);
                textBoxAccName.Clear();
                LoadAccessories();
                MessageBox.Show("Accessory added successfully");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Insert error:" + ex.Message);
            }

        }

        private void buttonDelAcc_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    int selectedId = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["AccessoryId"].Value);

                    DialogResult result = MessageBox.Show("Are you sure you want to delete this accessory?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        _accessoryDAL.DeleteAccessory(selectedId);
                        LoadAccessories();
                        MessageBox.Show("Accessory deleted successfully");
                    }
                }

                else
                {
                    MessageBox.Show("Please select a row to delete");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Delete error: " + ex.Message);
            }
        }
    }
}

    

