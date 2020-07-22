using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfSubCategoryRepository : ISubCategoryRepository
    {
        public ShopHomeContext context;

        public EfSubCategoryRepository(ShopHomeContext context)
        {
            this.context = context;
        }

        public List<SubCategory> AllSubCategories()
        {
            return context.SubCategories.ToList();
        }

        public List<SubCategory> GetSubCategories(int Id)
        {
            throw new NotImplementedException();
        }
    }
}
