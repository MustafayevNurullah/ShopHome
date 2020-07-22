using ShopHome.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Abstract
{
   public interface IToday_is_offerRepository
    {
        List<Today_is_offer> Alltoday_is_offers();
    }
}
