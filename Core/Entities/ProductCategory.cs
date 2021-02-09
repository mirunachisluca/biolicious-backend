﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class ProductCategory : BaseEntity
    {
        public string Name { get; set; }
        public IEnumerable<ProductSubcategory> Subcategories { get; set; }
    }
}