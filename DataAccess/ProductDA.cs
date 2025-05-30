using System;
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
    public class ProductDA : BaseDA
    {
        public ProductDA() : base(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\Warehouse_DB.mdf;Integrated Security=True") { }

        public void AddProduct(Product product) 
        {  
            OpenConnection();

            string query = "INSERT INTO Products (ProductName, AccessoryId, SupplierId, Product_Quantity) VALUES (@name, @accessoryId, @supplierId, @quantity)";
            SqlCommand cmd = new SqlCommand(query, _con);
            cmd.Parameters.AddWithValue("@name", product.ProductName);
            cmd.Parameters.AddWithValue("@accessoryId", product.AccessoryId);
            cmd.Parameters.AddWithValue("@supplierId", product.SupplierId);
            cmd.Parameters.AddWithValue("@quantity", product.ProductQuantity);

            cmd.ExecuteNonQuery();
            CloseConnection();  
        }

        public void DeleteProduct(int productId)
        {
            OpenConnection();

            string query = "DELETE FROM Products WHERE ProductId = @id";
            SqlCommand cmd = new SqlCommand(query, _con);
            cmd.Parameters.AddWithValue("@id", productId);

            cmd.ExecuteNonQuery();
            CloseConnection();
        }

        public DataTable GetAllProducts()
        {
            string query = @"
                        SELECT 
                            p.ProductId,
                            p.ProductName,
                            a.AccessoryName,
                            s.SupplierName,
                            p.Product_Quantity
                        FROM
                            Products p
                        JOIN
                            Accessories a ON p.AccessoryId = a.AccessoryId
                        JOIN
                            Supplier s ON p.SupplierId = s.SupplierId";

            SqlDataAdapter da = new SqlDataAdapter(query, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetAccessories()
        {
            string query = "SELECT AccessoryId, AccessoryName FROM Accessories";
            SqlDataAdapter da = new SqlDataAdapter(query, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }

        public DataTable GetSuppliers()
        {
            string query = @"SELECT SupplierId, SupplierName FROM Supplier";
            SqlDataAdapter da = new SqlDataAdapter(query, _con);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
