using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfSlidersRepository : ISlidersRepository
    {
        public ShopHomeContext context;
        public EfSlidersRepository(ShopHomeContext context)
        {

            this.context = context;
        }

        public List<Sliders> AllSliders()
        {
            List<discount_of_the_day> discount_Of_The_Days = context.Discount_Of_The_Days.ToList();
            List<Fixed_photo> fixed_Photos = context.Fixed_Photos.ToList();
            List<last_15_sold> last_15_Solds = context.Last_15_Solds.ToList();
            List<Offers> offers = context.Offers.ToList();
            List<Slider> slider = context.Slider.ToList();
            List<Sliders> sliders = context.Sliders.ToList();
            List<Today_is_offer> today_Is_Offers = context.Today_Is_Offers.ToList();
            sliders[0].discount_Of_The_Days = discount_Of_The_Days;
            sliders[0].fixed_Photos = fixed_Photos;
            sliders[0].last_15_Solds = last_15_Solds;
            sliders[0].Offers = offers;
            sliders[0].Slider = slider;
            sliders[0].GetToday_Is_Offers = today_Is_Offers;
                return sliders;
        }
    }
}
