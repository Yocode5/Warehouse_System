using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Warehouse_System.Models;

namespace Warehouse_System.DataAccess
{
    public class AccessoryDA : BaseDA
    {
        public AccessoryDA(string connectionString) : base(connectionString) { }
        public AccessoryDA()
           : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True") { }
        public void AddAccessory(Accessory accessory)
        {
            OpenConnection();

            string sqlQuery = $"Insert into Accessories (AccessoryName) VALUES (@name)"; ;
            SqlCommand cmd = new SqlCommand(sqlQuery, _con);
            cmd.Parameters.AddWithValue("@name", accessory.AccessoryName);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public void DeleteAccessory(int id)
        {
            OpenConnection();

            string sqlQuery = $"DELETE FROM Accessories WHERE AccessoryId = {id}";
            SqlCommand cmd = new SqlCommand(sqlQuery, _con);

            cmd.ExecuteNonQuery();

            CloseConnection();
        }

        public DataTable GetAccessories()
        {
            OpenConnection();

            string sqlQuery = "SELECT * FROM Accessories";
            SqlCommand cmd = new SqlCommand(sqlQuery, _con);

            SqlDataAdapter adapter = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            adapter.Fill(dt);
            CloseConnection();
            return dt;
        }
    }
}
