using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Abstract
{
   public interface IUnitOfWork:IDisposable
    {
         IProductRepository Products { get;}
        ISubCategoryRepository SubCategories { get; }
        ICategoryRepository Categories { get; }
        ISlidersRepository Sliders { get; }
        ISliderRepository Slider { get; }
        IDiscount_of_the_dayRepository Discount_Of_The_Days { get; }
        IFixed_photoRepository Fixed_Photo { get; }
        ILast_15_soldRepository Last_15_Solds { get; }
        IOfferRepository Offers { get; }
        IToday_is_offerRepository Today_Is_Offers { get; }
        int SaveChanges();
    }
}
