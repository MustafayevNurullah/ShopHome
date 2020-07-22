using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfLast_15_soldRepository : ILast_15_soldRepository
    {
        public ShopHomeContext context;

        public EfLast_15_soldRepository(ShopHomeContext context)
        {
            this.context = context;
        }


        

        public List<last_15_sold> Alllast_15_Solds()
        {
            List<last_15_sold> last_15_Solds = context.Last_15_Solds.ToList();
            return last_15_Solds;
        }
    }
}
