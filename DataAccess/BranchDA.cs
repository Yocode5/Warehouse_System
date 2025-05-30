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
            DataTable dt = new DataTable();
            string query = "SELECT * FROM Branch";

            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                OpenConnection();

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                adapter.Fill(dt);

                CloseConnection();
            }

            return dt;
        }

        //DB operation to Add a branch to the table
        public void AddBranch(Branch branch)
        {
            String query = "INSERT INTO Branch (BranchName, Location,ContactNo) VALUES(@BranchName, @Location, @ContactNo)";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                OpenConnection();

                cmd.Parameters.AddWithValue("@BranchName", branch.BranchName);
                cmd.Parameters.AddWithValue("@Location", branch.Location);
                cmd.Parameters.AddWithValue("@ContactNo", branch.ContactNo);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }

        public void DeleteBranch(int branchId)
        {
           
            string query = "DELETE FROM Branch WHERE BranchId = @BranchId";
            using (SqlCommand cmd = new SqlCommand(query, _con))
            {
                OpenConnection();

                cmd.Parameters.AddWithValue("BranchId", branchId);
                cmd.ExecuteNonQuery();

                CloseConnection();
            }
        }
    }
}
