using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_System.Models;

namespace Warehouse_System.DataAccess
{
    public class LoginDA : BaseDA
    {
        public LoginDA(string connectionString) : base(connectionString) { }

        public int? ValidateUser(LoginModel login)
        {
            try
            {
                OpenConnection();
                string query = "SELECT PositionID FROM Employee WHERE UserName = @username AND Password = @password";


                using (SqlCommand cmd = new SqlCommand(query, _con))
                {
                    cmd.Parameters.AddWithValue("@username", login.UserName);
                    cmd.Parameters.AddWithValue("@password", login.Password);

                    Object result = cmd.ExecuteScalar();

                    if (result != null)
                    {
                        return Convert.ToInt32(result);
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
