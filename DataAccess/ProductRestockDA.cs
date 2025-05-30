using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Warehouse_System.Models;
using System.Windows.Forms;

namespace Warehouse_System.DataAccess
{
    internal class ProductRestockDA : BaseDA
    {
        public ProductRestockDA(string connectionString) : base(connectionString) { }

        public ProductRestockDA()
            : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True") { }

        public DataTable LoadProducts()
        {
            try
            {
                OpenConnection();
                string query = "SELECT ProductId, ProductName FROM Products";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading products: " + ex.Message);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable LoadSuppliers()
        {
            try
            {
                OpenConnection();
                string query = "SELECT SupplierId, SupplierName FROM Supplier";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading suppliers: " + ex.Message);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        public DataTable LoadAccessories()
        {
            try
            {
                OpenConnection();
                string query = "SELECT AccessoryId, AccessoryName FROM Accessories";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                {
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error loading accessories: " + ex.Message);
                return null;
            }
            finally
            {
                CloseConnection();
            }
        }

        public void RestockProduct(ProductRestock restock)
        {
            SqlTransaction transaction = null;
            try
            {
                OpenConnection();
                transaction = _con.BeginTransaction();

                string insertQuery = @"INSERT INTO Restock_Master 
                    (ProductId, QTY, SupplierId, AccessoryId, RestockDate) 
                    VALUES (@ProductId, @QTY, @SupplierId, @AccessoryId, @RestockDate)";

                using (SqlCommand insertCmd = new SqlCommand(insertQuery, _con, transaction))
                {
                    insertCmd.Parameters.AddWithValue("@ProductId", restock.ProductId);
                    insertCmd.Parameters.AddWithValue("@QTY", restock.Quantity);
                    insertCmd.Parameters.AddWithValue("@SupplierId", restock.SupplierId);
                    insertCmd.Parameters.AddWithValue("@AccessoryId", restock.AccessoryId);
                    insertCmd.Parameters.AddWithValue("@RestockDate", restock.RestockDate);

                    insertCmd.ExecuteNonQuery();
                }

                string updateQuery = @"UPDATE Products 
                    SET Product_Quantity = Product_Quantity + @QTY 
                    WHERE ProductId = @ProductId";

                using (SqlCommand updateCmd = new SqlCommand(updateQuery, _con, transaction))
                {
                    updateCmd.Parameters.AddWithValue("@QTY", restock.Quantity);
                    updateCmd.Parameters.AddWithValue("@ProductId", restock.ProductId);
                    updateCmd.ExecuteNonQuery();
                }

                transaction.Commit();
                MessageBox.Show("Items Successfully Restocked");
            }
            catch (Exception ex)
            {
                transaction?.Rollback();
                MessageBox.Show("Restock process failed: " + ex.Message);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
