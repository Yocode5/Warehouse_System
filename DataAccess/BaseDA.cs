using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_System.DataAccess
{
    public class BaseDA
    {
        protected readonly SqlConnection _con;

        protected BaseDA(string connectionString)
        {
            _con = new SqlConnection(connectionString);
        }

        protected void OpenConnection()
        {
            if (_con.State != ConnectionState.Open)
            {
                _con.Open();
            }
        }

        protected void CloseConnection()
        {
            if (_con.State == ConnectionState.Open)
            {
                _con.Close();
            }
        }
    }
}
