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
using System.Windows.Forms.VisualStyles;
using Warehouse_System.DataAccess;
using Warehouse_System.Models;

namespace Warehouse_System
{
    public partial class SupplierForm : Form
    {
        private readonly SupplierDA _supplierDA;
        public SupplierForm()
        {
            InitializeComponent();

            string conString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\\Warehouse_DB.mdf;Integrated Security=True";
            _supplierDA = new SupplierDA(conString);
        }

        private void SupplierForm_Load(object sender, EventArgs e)
        {
            LoadSupplier();
            panelSUpdate.Visible = false;
        }

        private void LoadSupplier()
        {
            try
            {
                dataGridViewSupplier.DataSource = _supplierDA.GetSupplier();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Database connection error {ex.Message}");
            }
        }

        private void buttonSInsert_Click_1(object sender, EventArgs e)
        {
            try
            {
                Supplier supplier = new Supplier
                {
                    SupplierId = Convert.ToInt32(textBoxSId.Text),
                    SupplierName = textBoxSName.Text,
                    SupplierPhone = textBoxSPhone.Text,
                    SupplierEmail = textBoxSEmail.Text,
                    SupplierAddress = textBoxSAddress.Text
                };

                _supplierDA.AddSupplier(supplier);
                ClearInsertFields();
                LoadSupplier();
                MessageBox.Show("Record Inserted Successfully!");
            }

            catch (Exception ex)
            {
                MessageBox.Show("Unable to insert the record. Error: " + ex.Message);
            }
        }

        private void ClearInsertFields()
        {
            textBoxSId.Clear();
            textBoxSName.Clear();
            textBoxSPhone.Clear();
            textBoxSEmail.Clear();
            textBoxSAddress.Clear();
        }
        private void buttonSUpdateSelected_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewSupplier.SelectedCells.Count == 0)
                {
                    MessageBox.Show("Please select a row to update");
                    return;
                }

                panelSUpdate.Visible = true;
                DataGridViewRow row = dataGridViewSupplier.SelectedRows[0];

                textBoxUSId.Text = row.Cells["SupplierId"].Value.ToString();
                textBoxUSName.Text = row.Cells["SupplierName"].Value.ToString();
                textBoxUSPhone.Text = row.Cells["SupplierPhone"].Value.ToString();
                textBoxUSEmail.Text = row.Cells["SupplierEmail"].Value.ToString();
                textBoxUSAddress.Text = row.Cells["SupplierAddress"].Value.ToString();
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
                Supplier updatedSupplier = new Supplier
                {
                    SupplierId = Convert.ToInt32(textBoxUSId.Text),
                    SupplierName = textBoxUSName.Text,
                    SupplierPhone = textBoxUSPhone.Text,
                    SupplierEmail = textBoxUSEmail.Text,
                    SupplierAddress = textBoxUSAddress.Text
                };

                _supplierDA.UpdateSupplier(updatedSupplier);
                LoadSupplier();
                panelSUpdate.Visible = false;
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
                    int id = Convert.ToInt32(dataGridViewSupplier.SelectedCells[0].Value.ToString());

                    DialogResult result = MessageBox.Show("Are you sure you want to delete selected supplier?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        try
                        {
                            _supplierDA.DeleteSupplier(id);
                            LoadSupplier();
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
