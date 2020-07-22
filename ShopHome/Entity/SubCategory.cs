using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Entity
{
    [Table("SubCategory")]
    public class SubCategory
    {
        public int? Id { get; set; }
        public string Name { get; set; }
        [ForeignKey("CategoryId")]
        public int CategoryId { get; set; }
        public List<Product> ProductList { get; set; }
    }
}
