using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfUnitOfWork : IUnitOfWork
    {
        private readonly ShopHomeContext dbcontext;

        public EfUnitOfWork(ShopHomeContext dbcontext)
        {
            this.dbcontext = dbcontext;
        }

        public IProductRepository Products => new EfProductRepository(dbcontext);

        public ISubCategoryRepository SubCategories => new EfSubCategoryRepository(dbcontext);

        public ICategoryRepository Categories => new EfCategoryRepository(dbcontext);

        public ISlidersRepository Sliders =>  new EfSlidersRepository(dbcontext);

        public ISliderRepository Slider =>  new EfSliderRepository(dbcontext);

        public IDiscount_of_the_dayRepository Discount_Of_The_Days => new EfDiscount_of_dayRepository(dbcontext);

        public IFixed_photoRepository Fixed_Photo =>  new EfFixed_photoRepository(dbcontext);

        public ILast_15_soldRepository Last_15_Solds =>  new EfLast_15_soldRepository(dbcontext);

        public IOfferRepository Offers =>  new EfOfferRepository(dbcontext);

        public IToday_is_offerRepository Today_Is_Offers =>  new EfToday_is_offerRepository(dbcontext);

        public void Dispose()
        {
            dbcontext.Dispose();
        }

        public int SaveChanges()
        {
           return dbcontext.SaveChanges();
        }
    }
}
