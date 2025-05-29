using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

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

            //Application.Run(new Login());
            //Application.Run(new accessories());
            //Application.Run(new supplier());
            //Application.Run(new productNames());
            //Application.Run(new RestockProducts());
            //Application.Run(new DispatchItems());
            //Application.Run(new AdminUI());
            //Application.Run(new WarehouseManagerUI());
            //Application.Run(new WarehouseStaffUI());
        }
    }
}
