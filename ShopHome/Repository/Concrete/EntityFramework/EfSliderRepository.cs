using ShopHome.Entity;
using ShopHome.Repository.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShopHome.Repository.Concrete.EntityFramework
{
    public class EfSliderRepository : ISliderRepository
    {
        public ShopHomeContext context;

        public EfSliderRepository(ShopHomeContext context)
        {
            this.context = context;
        }
        

        public List<Slider> AllSlider()
        {
            List<Slider> sliders = context.Slider.ToList();
            return sliders;
        }
    }
}
