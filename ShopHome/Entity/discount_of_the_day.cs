using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Entity
{
    public class discount_of_the_day
    {
        public int Id { get; set; }
        public string Path { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
    }
}
