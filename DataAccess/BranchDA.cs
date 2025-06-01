using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_System.Models;

namespace Warehouse_System.DataAccess
{
    public class BranchDA : BaseDA
    {
        public BranchDA(string connectionString) : base(connectionString) { }

        //Retrieving data from the Branches
        public DataTable GetAllBranches()
        {
            try
            {
                OpenConnection();

                DataTable dt = new DataTable();
                string query = "SELECT * FROM Branch";

                using (SqlCommand cmd = new SqlCommand(query, _con))
                {

                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    adapter.Fill(dt);
                }
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

        //DB operation to Add a branch to the table
        public void AddBranch(Branch branch)
        {
            try
            {
                OpenConnection();

                String query = "INSERT INTO Branch (BranchName, Location,ContactNo) VALUES(@BranchName, @Location, @ContactNo)";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@BranchName", branch.BranchName);
                    cmd.Parameters.AddWithValue("@Location", branch.Location);
                    cmd.Parameters.AddWithValue("@ContactNo", branch.ContactNo);
                    cmd.ExecuteNonQuery();
                }
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

        public void DeleteBranch(int branchId)
        {
            try
            {
                OpenConnection();

                string query = "DELETE FROM Branch WHERE BranchId = @BranchId";
                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("BranchId", branchId);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error deleting the record", ex);
            }
            finally
            {
                CloseConnection();
            }
        }
    }
}
