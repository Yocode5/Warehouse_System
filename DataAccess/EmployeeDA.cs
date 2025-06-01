using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Warehouse_System.Models;
using System.Windows.Forms;

namespace Warehouse_System.DataAccess
{
    public class EmployeeDA:BaseDA
    {
        public EmployeeDA(string connectionString) : base(connectionString) { }
        public EmployeeDA()
           : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True") { }

        public void AddEmployee(Employee employee)
        {
            try
            {
                OpenConnection();

                string sqlQuery = $"Insert into Employee (EmployeeId, PositionId, FirstName, LastName, Email, UserName, Password) VALUES (@id, @positionId, @firstName, @lastName, @email, @username, @password)";
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                cmd.Parameters.AddWithValue("@id", employee.EmployeeId);
                cmd.Parameters.AddWithValue("@positionId", employee.PositionId);
                cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                cmd.Parameters.AddWithValue("@email", employee.Email);
                cmd.Parameters.AddWithValue("@username", employee.UserName);
                cmd.Parameters.AddWithValue("@password", employee.Password);

                cmd.ExecuteNonQuery();
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

        public void UpdateEmployee(Employee employee)
        {
            try
            {
                OpenConnection();

                string sqlQuery = $"UPDATE Employee SET PositionId=@positionId, FirstName=@firstName, LastName=@lastName, Email=@email, UserName=@username, Password=@pw WHERE EmployeeId=@id";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, _con))
                {
                    cmd.Parameters.AddWithValue("@id", employee.EmployeeId);
                    cmd.Parameters.AddWithValue("@positionId", employee.PositionId);
                    cmd.Parameters.AddWithValue("@firstName", employee.FirstName);
                    cmd.Parameters.AddWithValue("@lastName", employee.LastName);
                    cmd.Parameters.AddWithValue("@email", employee.Email);
                    cmd.Parameters.AddWithValue("@username", employee.UserName);
                    cmd.Parameters.AddWithValue("@pw", employee.Password);

                    cmd.ExecuteNonQuery();
                }
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
        public void DeleteEmployee(int EmployeeId)
        {
            try
            {
                OpenConnection();

                string sqlQuery = $"DELETE FROM Employee WHERE EmployeeId = @id";
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                cmd.Parameters.AddWithValue("@id", EmployeeId);

                cmd.ExecuteNonQuery();
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

        public DataTable GetEmployees()
        {
            try
            {
                OpenConnection();

                string sqlQuery = "SELECT * FROM Employee";
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
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

        public DataTable LoadPositions()
        {
            try
            {
                OpenConnection();
                string query = "SELECT PositionId, PositionName FROM Positions";
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
                throw new Exception("Error retrieving the record", ex);
            }
            finally
            {
                CloseConnection();
            }
        }

        public string GetPasswordByEmployeeId(int EmpId) 
        {
            try
            {
                OpenConnection();

                string sqlQuery = "SELECT Password FROM Employee WHERE EmployeeId=@empId";
                using (SqlCommand cmd = new SqlCommand(sqlQuery, _con))
                {
                    cmd.Parameters.AddWithValue("@empId", EmpId);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        return result.ToString();
                    }
                    else
                    {
                        return null;
                    }

                }
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
    }
}

