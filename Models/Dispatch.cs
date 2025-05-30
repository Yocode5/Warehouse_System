using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_System.Models
{
    public class Dispatch
    {
        public int BranchId { get; set; }
        public int ProductId { get; set; }
        public int AccessoryId { get; set; }
        public int Quantity { get; set; }
        public DateTime DispatchDate { get; set; }
    }
}
