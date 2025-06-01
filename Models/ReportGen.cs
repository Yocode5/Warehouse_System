using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Warehouse_System.DataAccess;

namespace Warehouse_System.Models
{
    class ReportGen
    {
        private ReportDA reportDA;
        public ReportGen(string connectionString)
        {
            reportDA = new ReportDA(connectionString);
        }

        public DataTable GetRestockReport(DateTime startDate)
        {
            return reportDA.GetRestockData(startDate);
        }

        public DataTable GetDispatchReport(DateTime startDate)
        {
            return reportDA.GetDispatchData(startDate);
        }

        public DataTable GetProductsReport()
        {
            return reportDA.GetProductData();
        }

        public (string topDispatch, string topRestock, string topSupplier) GetInsights(DateTime startDate)
        {
            var result = reportDA.GetInsights(startDate);
            return result;
        }
    }
}
