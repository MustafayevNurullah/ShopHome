using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfFixed_photoRepository : IFixed_photoRepository
    {
        public ShopHomeContext context;

        public EfFixed_photoRepository(ShopHomeContext context)
        {
            this.context = context;
        }


        

        public List<Fixed_photo> Allfixed_Photos()
        {
            List<Fixed_photo> fixed_Photos = context.Fixed_Photos.ToList();
            return fixed_Photos;
        }
    }
}
