﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Warehouse_System.Models
{
    public class Product
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public int AccessoryId { get; set; }
        public int SupplierId { get; set; }
        public int ProductQuantity { get; set; }
    }
}
