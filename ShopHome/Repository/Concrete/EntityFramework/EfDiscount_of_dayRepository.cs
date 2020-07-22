using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfDiscount_of_dayRepository  : IDiscount_of_the_dayRepository
    {
        public ShopHomeContext context;

        public EfDiscount_of_dayRepository(ShopHomeContext context)
        {
            this.context = context;
        }


        public List<discount_of_the_day> Alldiscount_Of_The_Days()
        {
           List<discount_of_the_day> discount_of_the_days = context.Discount_Of_The_Days.ToList();
            return discount_of_the_days;
        }
    }
}
