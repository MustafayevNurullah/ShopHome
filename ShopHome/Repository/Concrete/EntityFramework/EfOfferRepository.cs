using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfOfferRepository : IOfferRepository
    {
        public ShopHomeContext context;

        public EfOfferRepository(ShopHomeContext context)
        {
            this.context = context;
        }


        


        public List<Offers> AllOffers()
        {
            List<Offers> offers = context.Offers.ToList();
            return offers;
        }
    }
}
