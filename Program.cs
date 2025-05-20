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
            //Application.Run(new accessories());
            //Application.Run(new supplier());
            Application.Run(new productNames());
            //Application.Run(new RestockProducts());
            //Application.Run(new DispatchItems());
        }
    }
}
