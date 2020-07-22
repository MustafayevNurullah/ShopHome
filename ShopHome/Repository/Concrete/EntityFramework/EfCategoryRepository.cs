using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfCategoryRepository : ICategoryRepository
    {
        public ShopHomeContext context;
        public EfCategoryRepository(ShopHomeContext context)
        {
           
            this.context = context;
        }

        public List<Category> AllCategory()
        {
            List<Product> products = context.Products.ToList();
            List<SubCategory> subCategories = context.SubCategories.ToList();
            List<Category> categories= context.Categories.ToList();
            foreach (var item in subCategories)
            {
                item.ProductList = new List<Product>();
                item.ProductList.AddRange(products.Where(x => x.SubCategoryId == item.Id));
            }

            foreach (var item in categories)
            {
                item.SubCategoryList = new List<SubCategory>();
                item.SubCategoryList.AddRange(subCategories.Where(x => x.CategoryId == item.Id));
            }

            return categories;
        }
    }
}
