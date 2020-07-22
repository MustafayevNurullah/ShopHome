using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfToday_is_offerRepository : IToday_is_offerRepository
    {
        public ShopHomeContext context;

        public EfToday_is_offerRepository(ShopHomeContext context)
        {
            this.context = context;
        }
        

        public List<Today_is_offer> Alltoday_is_offers()
        {
            List<Today_is_offer> today_Is_Offers = context.Today_Is_Offers.ToList();
            return today_Is_Offers;
        }
    }
}
