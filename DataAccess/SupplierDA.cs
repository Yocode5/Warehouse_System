using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Warehouse_System.Models;

namespace Warehouse_System.DataAccess
{
    public class SupplierDA : BaseDA
    {
        public SupplierDA(string connectionString) : base(connectionString) { }
        public SupplierDA()
           : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True") { }

        public void AddSupplier(Supplier supplier)
        {
            try
            {
                OpenConnection();

                string sqlQuery = $"Insert into Supplier (SupplierId, SupplierName, SupplierPhone, SupplierEmail, SupplierAddress) VALUES (@id, @name, @phone, @email, @address)";
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                cmd.Parameters.AddWithValue("@id", supplier.SupplierId);
                cmd.Parameters.AddWithValue("@name", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@phone", supplier.SupplierPhone);
                cmd.Parameters.AddWithValue("@email", supplier.SupplierEmail);
                cmd.Parameters.AddWithValue("@address", supplier.SupplierAddress);

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

        public void UpdateSupplier(Supplier supplier)
        {
            try
            {
                OpenConnection();

                string sqlQuery = $"UPDATE Supplier SET SupplierName=@name, SupplierPhone=@phone, SupplierEmail=@email, SupplierAddress=@address WHERE SupplierId=@id";
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                cmd.Parameters.AddWithValue("@id", supplier.SupplierId);
                cmd.Parameters.AddWithValue("@name", supplier.SupplierName);
                cmd.Parameters.AddWithValue("@phone", supplier.SupplierPhone);
                cmd.Parameters.AddWithValue("@email", supplier.SupplierEmail);
                cmd.Parameters.AddWithValue("@address", supplier.SupplierAddress);

                cmd.ExecuteNonQuery();
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

        public void DeleteSupplier(int supplierId)
        {
            try
            {
                OpenConnection();

                string sqlQuery = $"DELETE FROM Supplier WHERE SupplierId = @id";
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);
                cmd.Parameters.AddWithValue("@id", supplierId);

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

        public DataTable GetSupplier()
        {
            try
            {
                OpenConnection();

                string sqlQuery = "SELECT * FROM Supplier";
                SqlCommand cmd = new SqlCommand(sqlQuery, _con);

                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                CloseConnection();
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
    }
}
