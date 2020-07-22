using ShopHome.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Abstract
{
  public  interface IDiscount_of_the_dayRepository
    {
         List<discount_of_the_day> Alldiscount_Of_The_Days();
    }
}
