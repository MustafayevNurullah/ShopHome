using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfProductRepository : IProductRepository
    {
        public ShopHomeContext context;

        public EfProductRepository(ShopHomeContext context)
        {
            this.context = context;
        }

        public List<Product> AllProducts()
        {
            return context.Products.ToList();
        }

        public List<Product> GetProducts(int Id)
        {
            throw new NotImplementedException();
        }

        public List<Product> Products(SubCategory sub)
        {
            return context.Products.Where(x => x.SubCategoryId == sub.Id).ToList();
        }
    }
}
