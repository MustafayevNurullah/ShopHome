using ShopHome.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Abstract
{
   public interface IOfferRepository
    {
        List<Offers> AllOffers();
    }
}
