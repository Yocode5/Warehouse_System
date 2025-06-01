using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_System.Models;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TreeView;

namespace Warehouse_System.DataAccess
{
    public class DispatchDA : BaseDA
    {
        public DispatchDA() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True") { }

        //Get the Branch information from the table
        public DataTable GetAllBranches()
        {
            try
            {
                OpenConnection();

                string query = "SELECT BranchId, BranchName FROM Branch";
                SqlDataAdapter da = new SqlDataAdapter(query, _con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving the record", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        //Get the Product information from the table
        public DataTable GetAllProducts()
        {
            try
            {
                OpenConnection();

                string query = "SELECT ProductId, ProductName FROM Products";
                SqlDataAdapter da = new SqlDataAdapter(query, _con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                return dt;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving the record", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public int GetProductsStock(int productId)
        {
            try
            {
                OpenConnection();

                string checkStockQuery = "SELECT Product_Quantity FROM Products WHERE ProductId = @ProductId";
                SqlCommand checkCmd = new SqlCommand(checkStockQuery, _con);
                checkCmd.Parameters.AddWithValue("@ProductId", productId);
                OpenConnection();
                int qty = Convert.ToInt32(checkCmd.ExecuteScalar());
                CloseConnection();
                return qty;
            }
            catch (Exception ex)
            {
                throw new Exception("Error retrieving the record", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        //Inserting data into the Dispatch_Master
        public void InsertDispatch(Dispatch dispatch)
        {
            try
            {
                OpenConnection();

                string query = @"INSERT INTO Dispatch_Master (BranchId, ProductId, QTY, DispatchDate) VALUES (@BRanchId, @ProductId, @QTY, @DispatchDate)";
                SqlCommand insertCmd = new SqlCommand(query, _con);
                insertCmd.Parameters.AddWithValue("@BranchId", dispatch.BranchId);
                insertCmd.Parameters.AddWithValue("@ProductId", dispatch.ProductId);
                insertCmd.Parameters.AddWithValue("@QTY", dispatch.Quantity);
                insertCmd.Parameters.AddWithValue("@DispatchDate", dispatch.DispatchDate);
                insertCmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Error inserting the record", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        //Updating Stock (Decrementing from the Products table)
        public void UpdateStock(int productId, int dispatchQTY)
        {
            try
            {
                OpenConnection();

                string query = "UPDATE Products SET Product_Quantity = Product_Quantity - @QTY WHERE ProductId = @ProductId";
                SqlCommand updateCmd = new SqlCommand(query, _con);
                updateCmd.Parameters.AddWithValue("@QTY", dispatchQTY);
                updateCmd.Parameters.AddWithValue("@ProductId", productId);
                updateCmd.ExecuteNonQuery();
            }

            catch (Exception ex)
            {
                throw new Exception("Error updating the record", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
