using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Warehouse_System.Forms;
using Warehouse_System.Models;

namespace Warehouse_System
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            string projectFolder = System.IO.Path.GetFullPath(System.IO.Path.Combine(Application.StartupPath, @"..\..\"));
            AppDomain.CurrentDomain.SetData("DataDirectory", projectFolder);

            //Application.Run(new LoginForm());
            //Application.Run(new BranchForm());
            //Application.Run(new AccessoryForm());
            //Application.Run(new SupplierForm());
            //Application.Run(new ProductForm());
            Application.Run(new ProductRestockForm());
            //Application.Run(new DispatchForm());
            //Application.Run(new AdminUI());
            //Application.Run(new WarehouseManagerUI());
            //Application.Run(new WarehouseStaffUI());
            //Application.Run(new EmployeeForm());
        }
    }
}
