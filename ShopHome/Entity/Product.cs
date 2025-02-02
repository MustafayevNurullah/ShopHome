﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Entity
{
    [Table("Product")]
    public class Product
    {

        public int? Id { get; set; }
        public string Name { get; set; }
        public string Path {get;set;}
        public double Price { get; set; }
        [ForeignKey("SubCategoryId")]
        public int SubCategoryId { get; set; }

    }
}
