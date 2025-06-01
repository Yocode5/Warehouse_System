using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_System.DataAccess
{
    class ReportDA : BaseDA
    {
        public ReportDA(string connectionString) : base(connectionString) { }

        //Creating a Method to fetch Restock Data
        public DataTable GetRestockData(DateTime startDate)
        {
            OpenConnection();
            //Creating queries to retrieve data from the log Tables
            string RestockQuery = @"
                            SELECT P.ProductName, S.SupplierName, A.AccessoryName, RM.QTY, RM.RestockDate
                            FROM Restock_Master RM
                            JOIN Products P ON RM.ProductId = P.ProductId
                            JOIN Supplier S ON RM.SupplierId = S.SupplierId
                            JOIN Accessories A ON RM.AccessoryId = A.AccessoryId
                            WHERE RM.RestockDate >= @StartDate";

            DataTable restockTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(RestockQuery, _con))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(restockTable);
                CloseConnection();
            }
            return restockTable;
            
        }

        //Creating a Method to fetch Dispatch Data
        public DataTable GetDispatchData(DateTime startDate)
        {
            OpenConnection();
            //Creating queries to retrieve data from the log Tables
            string DispatchQuery = @"
                            SELECT P.ProductName, B.BranchName, DM.QTY, DM.DispatchDate
                            FROM Dispatch_Master DM
                            JOIN Products P ON DM.ProductId = P.ProductId
                            JOIN Branch B ON DM.BranchId = B.BranchId
                            WHERE DM.DispatchDate >= @StartDate";

            DataTable dispatchTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(DispatchQuery, _con))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dispatchTable);
                CloseConnection();
            }
            return dispatchTable;
        }

        public DataTable GetProductData()
        {
            OpenConnection();
            string ProductsQuery = @"
                            SELECT P.ProductId, P.ProductName, A.AccessoryName, S.SupplierName, P.Product_Quantity
                            FROM Products P
                            LEFT JOIN Accessories A ON P.AccessoryId = A.AccessoryId
                            LEFT JOIN Supplier S ON P.SupplierId = S.SupplierId";

            DataTable productsTable = new DataTable();
            using (SqlCommand cmd = new SqlCommand(ProductsQuery, _con))
            {
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(productsTable);
                CloseConnection();
            }
            return productsTable;
        }

        //Queries created to retrieve insoghts from the records on those log tables
        public (string topDispatch, string topRestock, string topSupplier) GetInsights(DateTime startDate)
        {
            OpenConnection();
            string insightsQuery = @"
                SELECT TOP 1 P.ProductName, COUNT(*) as Count FROM Dispatch_Master DM
                JOIN Products P ON DM.ProductId = P.ProductId
                WHERE DM.DispatchDate >= @StartDate
                GROUP BY P.ProductName ORDER BY Count DESC;

                SELECT TOP 1 P.ProductName, COUNT(*) as Count FROM Restock_Master RM
                JOIN Products P ON RM.ProductId = P.ProductId
                WHERE RM.RestockDate >= @StartDate
                GROUP BY P.ProductName ORDER BY Count DESC;

                SELECT TOP 1 S.SupplierName, COUNT(*) as Count FROM Restock_Master RM
                JOIN Supplier S ON RM.SupplierId = S.SupplierId
                WHERE RM.RestockDate >= @StartDate
                GROUP BY S.SupplierName ORDER BY Count DESC;";

            //Creating a Command Object to fetch Insight Data
            using (SqlCommand cmd = new SqlCommand(insightsQuery, _con))
            {
                cmd.Parameters.AddWithValue("@StartDate", startDate);
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    string topDispatched = "-", topRestocked = "-", topSupplier = "-";

                    if (reader.Read()) topDispatched = reader.GetString(0);
                    if (reader.NextResult() && reader.Read()) topRestocked = reader.GetString(0);
                    if (reader.NextResult() && reader.Read()) topSupplier = reader.GetString(0);

                    CloseConnection();
                    return (topDispatched, topRestocked, topSupplier);

                }
            }
        }
    }
}
