﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestNab.Models
{
    public class ProductCategory
    {
        public int ProductCategoryId { get; set; }
        public string? ProductName {  get; set; }
        public int CategoryId { get; set; }
        public int? Quantity { get; set; }
        public string? Metric { get; set; }

        public string? Merchant { get; set; }
    }
}
